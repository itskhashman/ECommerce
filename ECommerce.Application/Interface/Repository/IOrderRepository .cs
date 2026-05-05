

using ECommerce.Domain.Entities.Sales;

namespace ECommerce.Application.Interface.Repository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        public Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId);
    }
}
