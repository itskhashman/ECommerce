

namespace ECommerce.Application.Interface.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<T?> GetByIDAsync(int id);
        public Task<IEnumerable<T>> GetAll();
        public Task<T> Add(T entity);
        public Task<T> Update(T entity);
        public Task Delete(int id);

    }
}
