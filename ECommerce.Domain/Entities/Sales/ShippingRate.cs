

using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Sales.Lookups;
using ECommerce.Domain.Entities.Users;
using ECommerce.Domain.Entities.Users.Lookups;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Sales
{
    public class ShippingRate : BaseEntity
    {
        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; } = null!;
        public decimal ShippingCost { get; set; }
    }

}
