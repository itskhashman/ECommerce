using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Users
{
    public class Wishlist : BaseEntity
    {
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<WishlistItem>? WishlistItems { get; set; } = new List<WishlistItem>();
    }

}
