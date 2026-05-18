

using ECommerce.Application.Interface.Repository;
using ECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ECommerce.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().Where(e => EF.Property<bool>(e, "IsDeleted") == false).ToListAsync();
        }

        public async Task<T?> GetByIDAsync(int id)
        {
            return await _context.Set<T>().Where(e => EF.Property<bool>(e,"IsDeleted") == false).FirstOrDefaultAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity != null)
            {
                entity.GetType().GetProperty("IsDeleted")?.SetValue(entity, true);
                await _context.SaveChangesAsync();
            }
        }
    }
}
