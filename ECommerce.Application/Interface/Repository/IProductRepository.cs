

using ECommerce.Domain.Entities.Products;

namespace ECommerce.Application.Interface.Repository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        public Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(int categoryId);
        public Task<Product?> GetAllProductDetailsAsync(int productId);
    }
}
