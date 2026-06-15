

using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Products;
using ECommerce.Domain.Entities.Products.Lookups;
using ECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<int?> GetTotalProductsAsync()
        {
            return await _context.Products.Where(p => !p.IsDeleted).CountAsync();
        }

        public async Task<Dictionary<int, Product>> GetTopProductsAsync()
        {
            var topProductsData = await _context.OrderItems
                .Where(oi => !oi.IsDeleted)
                .GroupBy(oi => oi.Sku.ProductId)
                .OrderByDescending(group => group.Sum(oi => oi.Quantity))
                .Take(5)
                .Select(group => new
                {
                    TotalSold = group.Sum(oi => oi.Quantity),
                    Product = group.Select(oi => oi.Sku.Product).FirstOrDefault()
                })
                .ToListAsync();

            return topProductsData
                .Where(x => x.Product != null)
                .ToDictionary(
                    x => x.TotalSold,
                    x => x.Product!
                );
        }
        public async Task<IEnumerable<Product>?> GetNewestProductsAsync()
        {
            var products = await _context.Products
                .Where(p => !p.IsDeleted && p.IsActive)
                .Include(p => p.ProductVariants)
                .Include(p => p.DiscountType)
                .Include(p => p.ProductImages)
                .OrderBy(p => p.CreatedAt)
                .Take(10)
                .ToListAsync();

            return products;
        }

        public async Task<IEnumerable<Product>?> GetProductsByCategoryIdAsync(int categoryId)
        {
            var Products = await _context.Products
                .AsNoTracking()
                .Where(p => p.CategoryId == categoryId && !p.IsDeleted && p.IsActive)
                .ToListAsync();
            return Products;
        }
        public async Task<Product?> GetProductBySkuId(int skuId)
        {
            return await _context.Products
                .AsNoTracking()
                .Include(p => p.Skus.Where(s => !s.IsDeleted && s.Id == skuId))
                .FirstOrDefaultAsync(p => p.Skus.Any(s => s.Id == skuId) && !p.IsDeleted);
        }
        public async Task<Product?> GetAllProductDetailsAsync(int productId)
        {
            return await _context.Products
                    .AsNoTracking()
                    .AsSplitQuery()
                    .Include(p => p.Category)
                    .Include(p => p.DiscountType)
                    .Include(p => p.ProductImages.Where(pi => !pi.IsDeleted))
                    .Include(p => p.ProductVariants.Where(pv => !pv.IsDeleted))
                        .ThenInclude(pv => pv.ProductVariantOptions.Where(pvo => !pvo.IsDeleted))
                    .Include(p => p.Skus.Where(s => !s.IsDeleted))
                        .ThenInclude(s => s.SKUJoinOptions)
                            .ThenInclude(jo => jo.ProductVariantOptions)
                                .ThenInclude(pvo => pvo.ProductVariant)
                    .FirstOrDefaultAsync(p => p.Id == productId && !p.IsDeleted);
        }

        public async Task<IEnumerable<Product>?> GetAllProductsWithMainImageAsync()
        {
            var productsList = await _context.Products
                .Where(p => !p.IsDeleted)
                .Include(p => p.ProductImages.Where(pi => !pi.IsDeleted && pi.IsMain))
                .ToListAsync();

            return productsList;
        }
        public async Task<IEnumerable<Product>?> GetMostReviewedProductsAsync() // needs update
        {
            var products = await _context.Products
                .Where(p => !p.IsDeleted && p.IsActive)
                .ToListAsync();
            return products;
        }

        public async Task<IEnumerable<DiscountType>?> GetDiscountTypesAsync()
        {
            var discountTypes = await _context.DiscountTypes
                .Where(dt => !dt.IsDeleted)
                .ToListAsync();
            return discountTypes;
        }

        public async Task<IEnumerable<Product>?> GetProductsByNameAsync(string name, int? categoryId, decimal? minPrice, decimal? maxPrice, bool inStockOnly = false)
        {
            var products = await _context.Products
                .Where(p => !p.IsDeleted && p.IsActive && EF.Functions.Like(p.NameEn, $"%{name}%"))
                .Include(p => p.ProductImages.Where(pi => !pi.IsDeleted && pi.IsMain))
                .Include(p => p.Skus.Where(s => !s.IsDeleted && s.Stock > 0))
                .ToListAsync();

            if (minPrice.HasValue)
            {
                products = products.Where(p => p.Skus.Any(s => s.Price >= minPrice.Value)).ToList();
            }

            if (maxPrice.HasValue)
            {
                products = products.Where(p => p.Skus.Any(s => s.Price <= maxPrice.Value)).ToList();
            }
            if (inStockOnly)
            {
                products = products.Where(p => p.Skus.Any(s => s.Stock > 0)).ToList();
            }
            if (categoryId.HasValue)
            {
                products = await _context.Products
                    .Where(p => p.Category.ParentCategoryId == categoryId.Value && !p.IsDeleted && p.IsActive && EF.Functions.Like(p.NameEn, $"%{name}%"))
                    .Include(p => p.ProductImages.Where(pi => !pi.IsDeleted && pi.IsMain))
                    .Include(p => p.Skus.Where(s => !s.IsDeleted))
                    .ToListAsync();
            }
            return products;
        }
        public async Task UpdateProductStockAsync(int skuId, int quantity)
        {
            var skusToUpdate = await _context.Skus
                .Where(s => s.Id == skuId)
                .FirstOrDefaultAsync();

            skusToUpdate.Stock -= quantity;

            await _context.SaveChangesAsync();
        }
    }
}