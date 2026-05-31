

using ECommerce.Domain.Entities.Products;
using ECommerce.Domain.Entities.Products.Lookups;

namespace ECommerce.Application.Interface.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId);
        public Task<Product?> GetAllProductDetailsAsync(int productId);
        public Task<IEnumerable<Product>> GetMostReviewedProductsAsync();
        public Task<IEnumerable<Product>> GetAllProductsWithMainImageAsync();
        public Task<IEnumerable<DiscountType>> GetDiscountTypesAsync();
    }
}
