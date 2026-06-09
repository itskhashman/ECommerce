
using ECommerce.Application.DTOs.Sku;

namespace ECommerce.Application.DTOs.Cart
{
    public class CartItemDto : BaseDto
    {
        public int CartId { get; set; }
        public CartDto Cart { get; set; } = null!;
        public int SkuId { get; set; }
        public SkuDto Sku { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal PriceAtAddTime { get; set; }
    }
}