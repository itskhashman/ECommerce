

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
        public string? FirstNameAr { get; set; }
        [MaxLength(30)]
        public string? MiddleNameAr { get; set; }
        [MaxLength(30)]
        public string? LastNameAr { get; set; }
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
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
        [EmailAddress]
        public string? Email { get; set; }
        public string? Phone { get; set; }
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
