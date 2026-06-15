

using ECommerce.Application.Interface.Repository;
using ECommerce.Domain.Entities.Users;
using ECommerce.Domain.Entities.Users.Lookups;
using ECommerce.Infrastructure.Data;
using ECommerce.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager) : base(context)
        {
            _userManager = userManager;
        }
        public async Task<int?> GetTotalUsersAsync()
        {
            return await _context.Users.CountAsync(u => !u.IsDeleted && u.IsActive);
        }
        public async Task<IEnumerable<User?>> GetAllUsersAsync()
        {
            return await _context.Users
                .Where(u => !u.IsDeleted )
                .Include(u => u.UserRoles)   
                    .ThenInclude(ur => ur.Role)
                .ToListAsync(); 
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
                .Include(u => u.Address.Where(ad => !ad.IsDeleted))
                .Include(u => u.UserRoles)
                    .ThenInclude(ur => ur.Role)
                .FirstOrDefaultAsync();
        }
        public async Task<User?> UpdateUserInfo(User user, int? RoleId)
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
                existingUser.IsActive = user.IsActive;
                existingUser.IsEmailVerified = user.IsEmailVerified;

                if (!string.IsNullOrEmpty(user.Email) && existingUser.Email != user.Email)
                {
                    existingUser.Email = user.Email;
                }

                if (RoleId.HasValue)
                {
                    var userRole = await _context.UsersRoles.FirstOrDefaultAsync(ur => ur.UserId == user.Id);
                    if (userRole != null)
                    {
                        userRole.RoleId = RoleId.Value;
                    }
                    else
                    {
                        await _context.UsersRoles.AddAsync(new UsersRoles { UserId = user.Id, RoleId = RoleId.Value });
                    }
                }

                var identityUser = await _userManager.Users.FirstOrDefaultAsync(u => u.DomainUserId == user.Id);
                if (identityUser != null)
                {
                    if (!string.IsNullOrEmpty(user.Email) && identityUser.Email != user.Email)
                    {
                        identityUser.Email = user.Email;
                        identityUser.NormalizedEmail = user.Email.ToUpperInvariant();
                    }

                    identityUser.PhoneNumber = user.Phone;
                    await _userManager.UpdateAsync(identityUser);

                    if (RoleId.HasValue)
                    {
                        string targetRoleName = RoleId.Value == 1 ? "Admin" : "Customer";
                        var currentIdentityRoles = await _userManager.GetRolesAsync(identityUser);

                        if (!currentIdentityRoles.Contains(targetRoleName))
                        {
                            await _userManager.RemoveFromRolesAsync(identityUser, currentIdentityRoles);
                            await _userManager.AddToRoleAsync(identityUser, targetRoleName);
                        }
                    }
                }

                await _context.SaveChangesAsync();
            }
            return existingUser;
        }
        public async Task<bool> SoftDeleteUserAsync(int userId)
        {
            var existingUser = await _context.Users.FindAsync(userId);
            if (existingUser == null) return false;

            existingUser.IsActive = false;
            existingUser.IsDeleted = true;
            existingUser.DeletedAt = DateTime.UtcNow;

            var userRoles = _context.UsersRoles.Where(ur => ur.UserId == userId);
            _context.UsersRoles.RemoveRange(userRoles);

            await _context.SaveChangesAsync();
            return true;
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