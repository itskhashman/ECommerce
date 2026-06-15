using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Products;
using ECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
        public async Task<Dictionary<int, Category>> GetTopCategoriesAsync()
        {
            var topCategoriesData = await _context.OrderItems
                .Where(oi => !oi.IsDeleted)
                .GroupBy(oi => oi.Sku.Product.CategoryId)
                .OrderByDescending(group => group.Sum(oi => oi.Quantity))
                .Take(5)
                .Select(group => new
                {
                    TotalSold = group.Sum(oi => oi.Quantity),
                    Category = group.Select(oi => oi.Sku.Product.Category).FirstOrDefault()
                })
                .ToListAsync();

            return topCategoriesData
                .Where(x => x.Category != null) 
                .ToDictionary(
                    x => x.TotalSold,
                    x => x.Category!
                );
        }
        public async Task<int> GetTotalCategoriesAsync()
        {
            return await _context.Categories
                .Where(c => !c.IsDeleted)
                .CountAsync();
        }
        public async Task<IEnumerable<Category>> GetMainCategoriesAsync()
        {
            return await _context.Categories
                .Where(c => !c.IsDeleted && c.IsActive && c.ParentCategoryId == null)
                .ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetSubCategoriesAsync()
        {
            return await _context.Categories
                .Where(c => !c.IsDeleted && c.IsActive && c.ParentCategoryId != null)
                .ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetSubCategoriesByMainCategoryIdAsync(int mainCategoryId)
        {
            return await _context.Categories
                .Where(c => !c.IsDeleted && c.IsActive && c.ParentCategoryId == mainCategoryId)
                .ToListAsync();
        }

    }
}