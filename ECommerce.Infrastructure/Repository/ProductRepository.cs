

using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Products;
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
            var Products = await _context.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
            return Products;
        }

        public async  Task<Product?> GetAllProductDetailsAsync(int productId)
        {
            var product = await _context.Products
                .Where(p => p.Id == productId)
                .Select(p => new Product
                {
                    Id = p.Id,
                    EnName = p.EnName,
                    EnDescription = p.EnDescription,
                    CategoryId = p.CategoryId,
                    Stock = p.Stock,
                    Rating = p.Rating,
                    ReviewCount = p.ReviewCount,
                    DefaultPrice = p.DefaultPrice,
                    DiscountAmount = p.DiscountAmount,
                    DiscountType = p.DiscountType,
                    ProductImages = p.ProductImages == null ? null : p.ProductImages.Select(pi => new ProductImage
                    {
                        Id = pi.Id,
                        URL = pi.URL
                    }).ToList(),
                    ProductVariants = p.ProductVariants == null ? null : p.ProductVariants.Select(pv => new ProductVariant
                    {
                        Id = pv.Id,
                        EnName = pv.EnName,
                        ProductVariantOptions = pv.ProductVariantOptions.Select(pvo => new ProductVariantOptions
                        {
                            Id = pvo.Id,
                            EnName = pvo.EnName,
                        }).ToList()
                    }).ToList(),
                    Skus = p.Skus== null ? null : p.Skus.Select(s => new Sku
                    {
                        Id = s.Id,
                        SkuCode = s.SkuCode,
                        Price = s.Price,
                        PriceUnit = s.PriceUnit
                    }).ToList()
                })
                .FirstOrDefaultAsync();
            return product;

        }
    }
}
