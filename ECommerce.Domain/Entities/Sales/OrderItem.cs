

using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Sales
{
    public class OrderItem : BaseEntity
    {
        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        [Required]
        public int OrderItemNumber { get; set; }
        [Required]
        [MaxLength(30)]
        [Column(TypeName = "varchar")]
        public string ProductNameEn { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string ProductNameAr { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string SkuCode { get; set; } = null!;
        public decimal SubTotal { get; set; }
        [Required]
        [ForeignKey("Sku")]
        public int SkuId { get; set; }
        public Sku Sku { get; set; } = null!;
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal PriceAtPurchase { get; set; }
        public decimal? DiscountAmount { get; set; }
    }

}
