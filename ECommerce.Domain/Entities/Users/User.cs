

using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Sales;
using ECommerce.Domain.Entities.Users.Lookups;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
        [EmailAddress]
        public string? Email { get; set; }
        public int? Phone { get; set; }
        [ForeignKey("CountryCode")]
        public int? CountryCodeId { get; set; }
        public CountryCode CountryCode { get; set; } = null!;
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
