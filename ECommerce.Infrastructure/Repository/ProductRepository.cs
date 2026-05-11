

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
            var Products = await _context.Product
                .AsNoTracking()
                .Where(p => p.CategoryId == categoryId && !p.IsDeleted && p.IsActive)
                .ToListAsync();
            return Products;
        }

        public async Task<Product?> GetAllProductDetailsAsync(int productId)
        {
            var product = await _context.Product
                .Where(p => p.Id == productId && !p.IsDeleted && p.IsActive)
                .Select(p => new Product
                {
                    Id = p.Id,
                    NameEn = p.NameEn,
                    DescriptionEn = p.DescriptionEn,
                    NameAr = p.NameAr,
                    DescriptionAr = p.DescriptionAr,
                    CategoryId = p.CategoryId,
                    DiscountAmount = p.DiscountAmount,
                    DiscountType = p.DiscountType,
                    ProductImages = p.ProductImages == null ? null : p.ProductImages.Select(pi => new ProductImage
                    {
                        Id = pi.Id,
                        URL = pi.URL,
                        IsMain = pi.IsMain,
                    }).Where(i => !i.IsDeleted).ToList(),
                    ProductVariants = p.ProductVariants == null ? null : p.ProductVariants.Select(pv => new ProductVariant
                    {
                        Id = pv.Id,
                        NameEn = pv.NameEn,
                        NameAr = pv.NameAr,
                        ProductVariantOptions =  pv.ProductVariantOptions.Select(pvo => new ProductVariantOptions
                        {
                            Id = pvo.Id,
                            NameEn = pvo.NameEn,
                            NameAr = pvo.NameAr,
                        }).Where(pvo => !pvo.IsDeleted).ToList()
                    }).Where(pv => !pv.IsDeleted).ToList(),
                    Skus = p.Skus == null ? null : p.Skus.Select(s => new Sku
                    {
                        Id = s.Id,
                        SkuCode = s.SkuCode,
                        Price = s.Price,
                    }).Where(s => !s.IsDeleted && s.IsActive).ToList()
                })
                .FirstOrDefaultAsync();
            return product;

        }
    }
}
