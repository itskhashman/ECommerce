using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Products;
using ECommerce.Infrastructure.Data;

namespace ECommerce.Infrastructure.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}