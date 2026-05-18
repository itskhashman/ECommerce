using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interface.Service;

namespace ECommerce.Application.Service
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericService(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<T?> GetByIDAsync(int id)
        {
            return await _repository.GetByIDAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}