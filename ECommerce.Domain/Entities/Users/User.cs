

using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Sales;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Users
{
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(30)]
        [Column(TypeName = "varchar")]
        public string FirstNameEn { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        [Column(TypeName = "varchar")]
        public string MiddleNameEn { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        [Column(TypeName = "varchar")]
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
        [Column(TypeName = "varchar")]
        public string Email { get; set; } = null!;
        [Required , MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string PasswordHash { get; set; } = null!;
        [Required , MaxLength(15)]
        [Column(TypeName = "varchar")]
        public string Phone { get; set; } = null!;
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public bool IsEmailVerified { get; set; } = true;
        public DateTime? LastLoginAt { get; set; }
        public ICollection<Order>? Orders { get; set; } = new List<Order>();
        public ICollection<Address>? Address { get; set; } = new List<Address>();
        public Cart Cart { get; set; } = null!;
        public Wishlist Wishlist { get; set; } = null!;
    }

}
