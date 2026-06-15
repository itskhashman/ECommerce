

using ECommerce.Application.DTOs.Cart;
using ECommerce.Application.DTOs.Order;

namespace ECommerce.Application.Interfaces
{
    public interface IOrderService
    {
        public Task<int?> GetTotalOrdersAsync();
        public Task<int?> GetTotalPendingAsync();
        public Task<int?> GetTotalConfirmedAsync();
        public Task<int?> GetTotalShippedAsync();
        public Task<int?> GetTotalDeliveredAsync();
        public Task<int?> GetTotalCancelledAsync();
        public Task<decimal?> GetTotalSalesAsync();
        public Task<Dictionary<DateTime, int>> GetLastWeekOrdersAsync();
        public Task<IEnumerable<OrderDto>?> GetRecentOrdersAsync();
        public Task<IEnumerable<OrderDto>?> GetAllOrdersAsync();
        public Task<IEnumerable<OrderDto>?> GetOrdersByUserIdAsync(int userId);
        public Task<OrderDto?> GetOrderWithDetailsAsync(int orderId);
        public Task<OrderDto?> CreateOrderByUserIdAsync(int userId, CartDto cart , int addressId, int paymentMethodId);
        public Task<OrderDto?> UpdateOrderAsync(int orderId, int orderStatusId);
        public Task DeleteOrderAsync(int orderId);

    }
}