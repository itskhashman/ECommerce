

using ECommerce.Domain.Entities.Base;

namespace ECommerce.Domain.Entities.Users.Lookups
{
    public class Country : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string IsoCode { get; set; } = null!;
        public ICollection<City>? Cities { get; set; } = new List<City>();
    }

}
