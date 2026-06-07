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
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        [MaxLength(500)]
        [Column(TypeName = "varchar")]
        public string? Notes { get; set; }
    }

}
