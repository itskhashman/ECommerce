

using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Users.Lookups
{
    public class City : LookupBaseEntity
    {
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
    }

}