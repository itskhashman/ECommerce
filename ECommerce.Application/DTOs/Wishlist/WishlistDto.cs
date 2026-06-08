

using ECommerce.Domain.Entities.Users;

namespace ECommerce.Application.DTOs.Wishlist
{
    public class WishlistDto : BaseDto
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<WishlistItemDto>? WishlistItems { get; set; } = new List<WishlistItemDto>();
    }
}
