

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
        public async Task<IEnumerable<User>> GetUsersByRoleAsync(string role)
        {
            return await _context.Users.Where(u => u.Role.RoleName == role).ToListAsync();
        }
        public async Task<string?> GetUserRoleAsync(int userId)
        {
            return await _context.Users.Where(u => u.Id == userId).Select(u => u.Role.RoleName).FirstOrDefaultAsync();
        }
        public async Task<User?> GetUserWithAddressesAsync(int userId)
        {
            return await _context.Users
                .Where(u => u.Id == userId)
                .Include(u => u.Address).FirstOrDefaultAsync();
        }
    }
}
