

using ECommerce.Application.DTOs.Cart;
using ECommerce.Application.DTOs.Order;

namespace ECommerce.Application.Interfaces
{
    public interface IOrderService
    {
        public Task<IEnumerable<OrderDto>> GetOrdersByUserIdAsync(int userId);
        public Task<OrderDto> GetOrderWithDetailsAsync(int orderId);
        public Task<OrderDto> CreateOrderByUserIdAsync(int userId, CartDto cart , int addressId, int paymentMethodId);
        public Task<OrderDto> UpdateOrderAsync(OrderDto orderUpdateDto);

    }
}