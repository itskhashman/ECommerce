

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
            return await _context.User.FirstOrDefaultAsync(u => u.Email == email);
        }
        public async Task<IEnumerable<User>> GetUsersByRoleAsync(int roleId)
        {
            return await _context.User.Where(u => u.RoleId == roleId).ToListAsync();
        }
        public async Task<string?> GetUserRoleAsync(int userId)
        {
            return await _context.User.Where(u => u.Id == userId)
                .Include(u => u.Role)
                .Select(u => u.Role.NameAr + " " + u.Role.NameEn)
                .FirstOrDefaultAsync();
        }
        public async Task<User?> GetUserWithAddressesAsync(int userId)
        {
            return await _context.User
                .Where(u => u.Id == userId)
                .Include(u => u.Address).FirstOrDefaultAsync();
        }
    }
}
