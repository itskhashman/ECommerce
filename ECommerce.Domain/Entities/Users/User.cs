

using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Sales;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Users
{
    public class User : BaseEntity
    {
        [MaxLength(30)]
        public string? ArFirstName { get; set; }
        [MaxLength(30)]
        public string? ArMiddleName { get; set; }
        [MaxLength(30)]
        public string? ArLastName { get; set; }
        [Required]
        [MaxLength(30)]
        public string EnFirstName { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string EnMiddleName { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string EnLastName { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string Role { get; set; } = null!;
        [EmailAddress]
        public string? Email { get; set; }
        public int? Phone { get; set; }
        public string? CountryCode { get; set; }
        public ICollection<Order>? Orders { get; set; } = new List<Order>();
        [Required]
        public int CartId { get; set; }
        public Cart Cart { get; set; } = null!;
        public int? AddressId { get; set; }
        public Address? Address { get; set; }
        [Required]
        public int WishlistId { get; set; }
        public Wishlist Wishlist { get; set; } = null!;
    }

}
