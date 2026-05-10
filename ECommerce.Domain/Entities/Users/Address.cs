using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Users.Lookups;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Users
{
    public class Address : BaseEntity
    {
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        [Required]
        public string Street { get; set; } = null!;
        [Required]
        public string PostalCode { get; set; } = null!;
        [ForeignKey("City")]
        public int CityId { get; set; }
        public City? City { get; set; }
        [ForeignKey("Country")]
        public int? CountryId { get; set; }
        public Country? Country { get; set; }
        public string? Label { get; set; }
        public bool IsDefault { get; set; }= true;

    }

}
