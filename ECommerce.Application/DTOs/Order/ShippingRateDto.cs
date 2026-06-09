

using ECommerce.Application.DTOs.Lookups;

namespace ECommerce.Application.DTOs.Order
{
    public class ShippingRateDto : BaseDto
    {
        public int CityId { get; set; }
        public CityDto City { get; set; } = null!;
        public decimal ShippingCost { get; set; }
    }
}
