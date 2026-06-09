

using ECommerce.Application.DTOs.Address;
using ECommerce.Application.DTOs.Lookups;
using ECommerce.Application.DTOs.User;

namespace ECommerce.Application.DTOs.Order
{
    public class OrderDto : BaseDto
    {
        public int UserId { get; set; }
        public UserDto User { get; set; } = null!;
        public string OrderNumber { get; set; } = null!;
        public decimal TotalAmount { get; set; }
        public int AddressId { get; set; }
        public AddressDto Address { get; set; } = null!;
        public int OrderStatusId { get; set; }
        public OrderStatusDto OrderStatus { get; set; } = null!;
        public int PaymentId { get; set; }
        public PaymentDto Payment { get; set; } = null!;
        public string CurrencyCode { get; set; } = null!;
        public decimal ShippingCost { get; set; }
        public string? Notes { get; set; }
        public ICollection<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();
    }
}
