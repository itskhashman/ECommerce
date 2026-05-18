using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Products;
using ECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace ECommerce.Infrastructure.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }


        public async Task<IEnumerable<Category>> GetParentsAsync()
        {
            return await _context.Categories
                .Where(c => !c.IsDeleted && c.ParentCategoryId == null)
                .ToListAsync();
        }

    }
}