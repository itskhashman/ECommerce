

using ECommerce.Domain.Entities.Products;

namespace ECommerce.Application.Interface.Repository
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        public Task<Dictionary<int, Category>> GetTopCategoriesAsync();
        public Task<int> GetTotalCategoriesAsync();
        public Task<IEnumerable<Category>?> GetMainCategoriesAsync();
        public Task<IEnumerable<Category>?> GetSubCategoriesAsync();
        public Task<IEnumerable<Category>?> GetSubCategoriesByMainCategoryIdAsync(int mainCategoryId);

    }
}
