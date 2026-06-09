

using ECommerce.Domain.Entities.Products;
using ECommerce.Domain.Entities.Products.Lookups;

namespace ECommerce.Application.Interface.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId);
        public Task<Product?> GetAllProductDetailsAsync(int productId);
        public Task<Product?> GetProductBySkuId(int skuId);
        public Task<IEnumerable<Product>> GetProductsByNameAsync(string name, int? categoryId, decimal? minPrice, decimal? maxPrice, bool inStockOnly = false);
        public Task<IEnumerable<Product>> GetMostReviewedProductsAsync();
        public Task<IEnumerable<Product>> GetAllProductsWithMainImageAsync();
        public Task<IEnumerable<DiscountType>> GetDiscountTypesAsync();
        public Task UpdateProductStockAsync(int skuId, int quantity);
    }
}
