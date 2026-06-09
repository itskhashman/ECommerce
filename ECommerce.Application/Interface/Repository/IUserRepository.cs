

using ECommerce.Application.DTOs.User;
using ECommerce.Domain.Entities.Users;
using ECommerce.Domain.Entities.Users.Lookups;

namespace ECommerce.Application.Interface.Repository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<User?> GetUserByEmailAsync(string email);
        public Task<IEnumerable<User>> GetUsersByRoleAsync(int roleId);
        public Task<string?> GetUserRoleAsync(int userId);
        public Task<User?> GetUserWithAddressesAsync(int userId);
        public Task<User?> UpdateUserInfo(User user);
        public Task<IEnumerable<Address>> GetUserAddressesAsync(int userId);
        public Task<IEnumerable<City>> GetAllCitiesAsync();
        public Task<IEnumerable<Country>> GetAllCountriesAsync();
        public Task AssignRoleToUserAsync(int userId, int roleId);
        public Task AddUserAddress(int userId, Address address);
        public Task UpdateUserAddress(int userId, Address address);
        public Task DeleteUserAddress(int userId, int addressId);
    }
}