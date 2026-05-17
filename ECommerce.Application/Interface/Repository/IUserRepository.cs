

using ECommerce.Domain.Entities.Users;

namespace ECommerce.Application.Interface.Repository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<User?> GetUserByEmailAsync(string email);
        public Task<IEnumerable<User>> GetUsersByRoleAsync(int roleId);
        public Task<string?> GetUserRoleAsync(int userId);
        public Task<User?> GetUserWithAddressesAsync(int userId);
    }
}