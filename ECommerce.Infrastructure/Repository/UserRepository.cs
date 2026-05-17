

using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Users;
using ECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }
        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
        public async Task<IEnumerable<User>> GetUsersByRoleAsync(int roleId)
        {
            List<UsersRoles> userRoles = await _context.UsersRoles
                .Where(ur => ur.RoleId == roleId)
                .Include(ur => ur.User)
                .ToListAsync();

            List<User> users = await _context.Users
                .Where(u => userRoles.Any(ur => ur.UserId == u.Id))
                .ToListAsync();

            return users;
        }
        public async Task<string?> GetUserRoleAsync(int userId)
        {
            return await _context.UsersRoles
                .Where(ur => ur.User.Id == userId)
                .Select(ur => ur.Role.NameEn)
                .FirstOrDefaultAsync();
        }
        public async Task<User?> GetUserWithAddressesAsync(int userId)
        {
            return await _context.Users
                .Where(u => u.Id == userId)
                .Include(u => u.Address).FirstOrDefaultAsync();
        }
    }
}
