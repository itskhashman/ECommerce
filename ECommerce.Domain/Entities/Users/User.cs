

using ECommerce.Domain.Entities.Sales;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string MiddleName { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; } = null!;
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
