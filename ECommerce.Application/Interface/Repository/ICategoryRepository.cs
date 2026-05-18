

using ECommerce.Domain.Entities.Products;

namespace ECommerce.Application.Interface.Repository
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        public Task<IEnumerable<Category>> GetParentsAsync();
    }
}
