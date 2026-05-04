

using ECommerce.Domain.Entities.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Sales
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        [Required]
        [ForeignKey("Sku")]
        public int SkuId { get; set; }
        public Sku Sku { get; set; } = null!;
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal PriceAtPurchase { get; set; }
        public decimal? Rating { get; set; }

    }

}
