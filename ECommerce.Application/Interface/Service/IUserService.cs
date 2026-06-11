
using ECommerce.Application.DTOs.Address;
using ECommerce.Application.DTOs.Lookups;
using ECommerce.Application.DTOs.User;

namespace ECommerce.Application.Interfaces
{
    public interface IUserService
    {
        public Task<IEnumerable<UserDto>?> GetAllUsersAsync();
        public Task<UserDto?> GetUserByEmailAsync(string email);
        public Task<IEnumerable<UserDto>> GetUsersByRoleAsync(int roleId);
        public Task<string?> GetUserRoleAsync(int userId);
        public Task<UserDto?> GetUserWithAddressesAsync(int userId);
        public Task<IEnumerable<AddressDto>> GetUserAddressesAsync(int userId);
        public Task<IEnumerable<CityDto>> GetAllCitiesAsync();
        public Task<IEnumerable<CountryDto>> GetAllCountriesAsync();
        public Task AssignRoleToUserAsync(int userId, int roleId);
        public Task<UserDto?> UpdateUserInfo(UpdateUserDto user);
        public Task<UserDto?> AddUserAddress(int userId, AddressDto address);
        public Task<UserDto?> UpdateUserAddress(int userId, AddressDto address);
        public Task<UserDto?> DeleteUserAddress(int userId, int addressId);
    }
}