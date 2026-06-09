

using ECommerce.Application.DTOs.Base;

namespace ECommerce.Application.DTOs.Lookups
{
    public class CityDto : LookupBaseEntityDto
    {
        public int CountryId { get; set; }
        public CountryDto Country { get; set; } = null!;
    }

}