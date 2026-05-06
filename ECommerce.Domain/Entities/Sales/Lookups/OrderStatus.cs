

using ECommerce.Domain.Entities.Base;

namespace ECommerce.Domain.Entities.Sales.Lookups
{
    public class OrderStatus : BaseEntity
    {
        public string StatusName { get; set; } = null!;
    }

}
