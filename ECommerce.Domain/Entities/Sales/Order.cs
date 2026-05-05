

using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Sales
{
    public class Order : BaseEntity
    {
        [Required]
        public int OrderNumber { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        [Required]
        public decimal TotalAmount { get; set; }
        [Required]
        [MaxLength(15)]
        public string Status { get; set; } = null!;
        [Required]
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; } = null!;
        [Required]
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }

}
