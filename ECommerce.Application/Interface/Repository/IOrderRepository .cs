

using ECommerce.Domain.Entities.Sales;

namespace ECommerce.Application.Interface.Repository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        public Task<IEnumerable<Order>?> GetAllOrdersAsync();
        public Task<IEnumerable<Order>?> GetOrdersByUserIdAsync(int userId);
        public Task<Order?> GetOrderWithDetailsAsync(int orderId);
        public Task<Order?> CreateOrderByUserIdAsync(int userId, Order order);
        public Task<Order?> UpdateOrderAsync(Order order);
        public Task<Order?> DeleteOrderAsync(int orderId);
        public Task<Order?> UpdateOrderStateAsync(int orderId , int orderStateId);

    }
}
