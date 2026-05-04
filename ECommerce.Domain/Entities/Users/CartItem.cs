using ECommerce.Domain.Entities.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Users
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public Cart Cart { get; set; } = null!;
        [Required]
        [ForeignKey("Sku")]
        public int SkuId { get; set; }
        public Sku Sku { get; set; } = null!;
        public int Quantity { get; set; }
    }

}
