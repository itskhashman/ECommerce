
using ECommerce.Application.DTOs.Products;

namespace ECommerce.Application.DTOs.Wishlist
{
    public class WishlistItemDto : BaseDto
    {
        public int WishlistId { get; set; }
        public int ProductId { get; set; }
        public ProductDto Product { get; set; }
        public string? Notes { get; set; }
    }
}
