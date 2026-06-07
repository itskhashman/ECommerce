

namespace ECommerce.Application.DTOs.Wishlist
{
    public class WishlistDto : BaseDto
    {
        public int UserId { get; set; }
        public ICollection<WishlistItemDto>? WishlistItems { get; set; } = new List<WishlistItemDto>();
    }
}
