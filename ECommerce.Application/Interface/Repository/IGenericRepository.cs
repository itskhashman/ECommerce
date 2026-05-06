

namespace ECommerce.Application.Interface.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<T?> GetByIDAsync(int id);
        public Task<IEnumerable<T>> GetAll();
        public Task Add(T entity);
        public Task Update(T entity);
        public Task Delete(int id);

    }
}
