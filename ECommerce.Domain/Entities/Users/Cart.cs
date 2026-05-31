using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Users
{
    public class Cart : BaseEntity
    {
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public DateTime? ExpiresAt { get; set; }
        public ICollection<CartItem>? CartItems { get; set; } = new List<CartItem>();
    }

}