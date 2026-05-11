using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Users
{
    public class WishlistItem : BaseEntity
    {
        [Required]
        [ForeignKey("Wishlist")]
        public int WishlistId { get; set; }
        public Wishlist Wishlist { get; set; } = null!;
        [Required]
        [ForeignKey("Sku")]
        public int SkuId { get; set; }
        public Sku Sku { get; set; } = null!;
        [MaxLength(500)]
        public string? Notes { get; set; }
    }

}
