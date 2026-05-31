namespace ECommerce.Application.Interface.Service
{
    public interface IGenericService<T> where T : class
    {
        Task<T?> GetByIDAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}