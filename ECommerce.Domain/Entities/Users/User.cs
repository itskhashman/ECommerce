

using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Sales;
using ECommerce.Domain.Entities.Users.Lookups;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Users
{
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(30)]
        public string FirstNameEn { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string MiddleNameEn { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string LastNameEn { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string FirstNameAr { get; set; } = null!;
        [MaxLength(30)]
        [Required]
        public string MiddleNameAr { get; set; } = null!;
        [MaxLength(30)]
        [Required]
        public string LastNameAr { get; set; } = null!;
        [Required , MaxLength(255)]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [Required , MaxLength(256)]
        public string PasswordHash { get; set; } = null!;
        [ForeignKey("Role")]
        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
        [Required , MaxLength(15)]
        public string Phone { get; set; } = null!;
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public bool IsEmailVerified { get; set; } = true;
        public DateTime? LastLoginAt { get; set; }
        public ICollection<Order>? Orders { get; set; } = new List<Order>();
        public int? CartId { get; set; }
        public Cart Cart { get; set; } = null!;
        public int? AddressId { get; set; }
        public Address Address { get; set; } = null!;
        public int? WishlistId { get; set; }
        public Wishlist Wishlist { get; set; } = null!;
    }

}
