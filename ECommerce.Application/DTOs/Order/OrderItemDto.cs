
using ECommerce.Application.DTOs.Sku;

namespace ECommerce.Application.DTOs.Order
{
    public class OrderItemDto : BaseDto
    {
        public int OrderId { get; set; }
        public OrderDto Order { get; set; } = null!;
        public int OrderItemNumber { get; set; }
        public string ProductNameEn { get; set; } = null!;
        public string ProductNameAr { get; set; } = null!;
        public string SkuCode { get; set; } = null!;
        public decimal SubTotal { get; set; }
        public int SkuId { get; set; }
        public SkuDto Sku { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal PriceAtPurchase { get; set; }
        public decimal? DiscountAmount { get; set; }
    }
}
