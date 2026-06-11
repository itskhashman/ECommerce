using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interface.Service;
using ECommerce.Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserRepository _userRepository;

        public IdentityService(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IUserRepository userRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userRepository = userRepository;
            _userRepository = userRepository;
        }

        public async Task<bool> RegisterAsync(
        string username, string email, string password,
        string firstNameAr, string middleNameAr, string lastNameAr,
        string firstNameEn, string middleNameEn, string lastNameEn,
        string phone, int roleId, string roleName)
        {
            var identityUser = new ApplicationUser
            {
                UserName = username,
                Email = email,
                PhoneNumber = phone
            };

            var result = await _userManager.CreateAsync(identityUser, password);

            if (result.Succeeded)
            {
                try
                {
                    var domainUser = new User
                    {
                        Email = email,
                        FirstNameAr = firstNameAr,
                        MiddleNameAr = middleNameAr,
                        LastNameAr = lastNameAr,
                        FirstNameEn = firstNameEn,
                        MiddleNameEn = middleNameEn,
                        LastNameEn = lastNameEn,
                        Phone = phone,
                        PasswordHash = identityUser.PasswordHash ?? string.Empty,
                        IsActive = true,
                        IsEmailVerified = false,
                    };

                    await _userRepository.AddAsync(domainUser);

                    identityUser.DomainUserId = domainUser.Id;
                    await _userManager.UpdateAsync(identityUser);

                    await _userManager.AddToRoleAsync(identityUser, roleName);

                    await _userRepository.AssignRoleToUserAsync(domainUser.Id, roleId);

                    return true;
                }
                catch (Exception)
                {
                    await _userManager.DeleteAsync(identityUser);
                    throw;
                }
            }

            return false;
        }
        public async Task<bool> DeleteAsync(int userId)
        {
            var domainResult = await _userRepository.SoftDeleteUserAsync(userId);
            if (!domainResult) return false;

            var identityUser = await _userManager.Users.FirstOrDefaultAsync(u => u.DomainUserId == userId);
            if (identityUser != null)
            {
                identityUser.LockoutEnabled = true;
                identityUser.LockoutEnd = DateTimeOffset.MaxValue;

                await _userManager.UpdateSecurityStampAsync(identityUser);

                var identityResult = await _userManager.UpdateAsync(identityUser);
                return identityResult.Succeeded;
            }

            return true;
        }
        public async Task<bool> LoginAsync(string email, string password, bool rememberMe)
        {
            var domainUser = await _userRepository.GetUserByEmailAsync(email);
            if (domainUser == null)
            {
                return false;
            }

            var identityUser = await _userManager.FindByEmailAsync(email);
            if (identityUser == null)
            {
                return false;
            }

            var result = await _signInManager.PasswordSignInAsync(identityUser.UserName, password, rememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                domainUser.LastLoginAt = DateTime.UtcNow;
                await _userRepository.UpdateAsync(domainUser);
                return true;
            }

            return false;
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}