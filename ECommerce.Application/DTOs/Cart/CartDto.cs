
using ECommerce.Domain.Entities.Users;

namespace ECommerce.Application.DTOs.Cart
{
    public class CartDto : BaseDto
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public DateTime? ExpiresAt { get; set; }
        public ICollection<CartItemDto>? CartItems { get; set; } = new List<CartItemDto>();
    }
}
