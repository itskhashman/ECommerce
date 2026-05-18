

namespace ECommerce.Application.Interface.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<T?> GetByIDAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> AddAsync(T entity);
        public Task<T> UpdateAsync(T entity);
        public Task DeleteAsync(int id);

    }
}
