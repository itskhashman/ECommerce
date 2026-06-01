

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

        public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            var Products = await _context.Products
                .AsNoTracking()
                .Where(p => p.CategoryId == categoryId && !p.IsDeleted && p.IsActive)
                .ToListAsync();
            return Products;
        }

        public async Task<Product?> GetAllProductDetailsAsync(int productId)
        {
            return await _context.Products
                .AsNoTracking()
                .Include(p => p.Category)
                .Include(p => p.DiscountType)
                .Include(p => p.ProductImages.Where(pi => !pi.IsDeleted))
                .Include(p => p.ProductVariants.Where(pv => !pv.IsDeleted))
                    .ThenInclude(pv => pv.ProductVariantOptions.Where(pvo => !pvo.IsDeleted))
                .Include(p => p.Skus.Where(s => !s.IsDeleted))
                .FirstOrDefaultAsync(p => p.Id == productId && !p.IsDeleted);
        }

        public async Task<IEnumerable<Product>> GetAllProductsWithMainImageAsync()
        {
            var productsList = await _context.Products
                .Where(p => !p.IsDeleted)
                .Include(p => p.ProductImages.Where(pi => !pi.IsDeleted && pi.IsMain)) 
                .ToListAsync();

            return productsList;
        }
        public async Task<IEnumerable<Product>> GetMostReviewedProductsAsync() // needs update
        {
            var products = await _context.Products
                .Where(p => !p.IsDeleted && p.IsActive)
                .ToListAsync();
            return products;
        }

        public async Task<IEnumerable<DiscountType>> GetDiscountTypesAsync()
        {
            var discountTypes = await _context.DiscountTypes
                .Where(dt => !dt.IsDeleted)
                .ToListAsync();
            return discountTypes;
        }
    }
}