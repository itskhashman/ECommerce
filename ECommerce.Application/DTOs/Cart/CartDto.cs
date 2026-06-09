
using ECommerce.Application.DTOs.User;

namespace ECommerce.Application.DTOs.Cart
{
    public class CartDto : BaseDto
    {
        public int UserId { get; set; }
        public UserDto User { get; set; } = null!;
        public DateTime? ExpiresAt { get; set; }
        public ICollection<CartItemDto>? CartItems { get; set; } = new List<CartItemDto>();
    }
}
