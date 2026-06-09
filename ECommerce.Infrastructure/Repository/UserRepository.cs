

using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Users;
using ECommerce.Domain.Entities.Users.Lookups;
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
                .Include(u => u.Address.Where(ad => !ad.IsDeleted)).FirstOrDefaultAsync();
        }
        public async Task<User?> UpdateUserInfo(User user)
        {
            var existingUser = await _context.Users.FindAsync(user.Id);
            if (existingUser != null)
            {
                existingUser.FirstNameEn = user.FirstNameEn;
                existingUser.MiddleNameEn = user.MiddleNameEn;
                existingUser.LastNameEn = user.LastNameEn;
                existingUser.FirstNameAr = user.FirstNameAr;
                existingUser.MiddleNameAr = user.MiddleNameAr;
                existingUser.LastNameAr = user.LastNameAr;
                existingUser.Phone = user.Phone;
                await _context.SaveChangesAsync();
            }
            return existingUser;
        }
        public async Task AssignRoleToUserAsync(int userId, int roleId)
        {
            var userRole = new UsersRoles
            {
                UserId = userId,
                RoleId = roleId
            };
            await _context.UsersRoles.AddAsync(userRole);
            await _context.SaveChangesAsync();
        }
        public async Task AddUserAddress(int userId, Address address)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                user.Address.Add(address);
                await _context.SaveChangesAsync();
            }
        }
        public async Task UpdateUserAddress(int userId, Address address)
        {
            var user = await _context.Users
                .Include(u => u.Address)
                .FirstOrDefaultAsync(u => u.Id == userId);
            if (user != null)
            {
                var existingAddress = user.Address.FirstOrDefault(a => a.Id == address.Id);
                if (existingAddress != null)
                {
                    existingAddress.Street = address.Street;
                    existingAddress.PostalCode = address.PostalCode;
                    existingAddress.CityId = address.CityId;
                    existingAddress.Label = address.Label;
                    existingAddress.IsDefault = address.IsDefault;
                    await _context.SaveChangesAsync();
                }
            }
        }
        public async Task DeleteUserAddress(int userId, int addressId)
        {
            var user = await _context.Users
                .Include(u => u.Address)
                .FirstOrDefaultAsync(u => u.Id == userId);
            if (user != null)
            {
                var addressToRemove = user.Address.FirstOrDefault(a => a.Id == addressId);
                if (addressToRemove != null)
                {
                    addressToRemove.IsDeleted = true;
                    await _context.SaveChangesAsync();
                }
            }
        }
        public async Task<IEnumerable<Address>> GetUserAddressesAsync(int userId)
        {
            var user = await _context.Users
                .Include(u => u.Address.Where(ad => !ad.IsDeleted))
                    .ThenInclude(ad => ad.City)
                        .ThenInclude(c => c.Country)
                .FirstOrDefaultAsync(u => u.Id == userId);
            return user?.Address;
        }
        public async Task<IEnumerable<City>> GetAllCitiesAsync()
        {
            return await _context.Cities.ToListAsync();
        }
        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
        {
            return await _context.Countries.ToListAsync();
        }
    }
}