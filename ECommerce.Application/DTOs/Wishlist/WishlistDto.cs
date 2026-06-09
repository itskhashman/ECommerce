

using ECommerce.Application.DTOs.User;

namespace ECommerce.Application.DTOs.Wishlist
{
    public class WishlistDto : BaseDto
    {
        public int UserId { get; set; }
        public UserDto User { get; set; } = null!;
        public ICollection<WishlistItemDto>? WishlistItems { get; set; } = new List<WishlistItemDto>();
    }
}
