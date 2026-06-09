
using ECommerce.Application.DTOs.Lookups;
using ECommerce.Application.DTOs.User;

namespace ECommerce.Application.DTOs.Address
{
    public class AddressDto : BaseDto
    {
        public int? UserId { get; set; }
        public UserDto? User { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public int CityId { get; set; }
        public CityDto? City { get; set; }
        public string? Label { get; set; }
        public bool IsDefault { get; set; }
    }
}
