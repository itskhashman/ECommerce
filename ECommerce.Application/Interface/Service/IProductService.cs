using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Products;

namespace ECommerce.Application.Interfaces.services
{
    public interface IProductService : IGenericRepository<Product>
    {
    }
}