using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Users
{
    public class CartItem : BaseEntity
    {
        [Required]
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public Cart Cart { get; set; } = null!;
        [Required]
        [ForeignKey("Sku")]
        public int SkuId { get; set; }
        public Sku Sku { get; set; } = null!;
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal PriceAtAddTime { get; set; }
    }

}
