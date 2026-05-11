using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interface.Service;
using ECommerce.Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;

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
        }

        public async Task<bool> RegisterAsync(string email, string password, string firstNameAr, string middleNameAr, string lastNameAr, string firstNameEn, string middleNameEn, string lastNameEn, string phone)
        {
            var identityUser = new ApplicationUser
            {
                UserName = firstNameEn + '-' + middleNameEn + '-' + lastNameEn,
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
                        FirstNameEn = firstNameEn,
                        LastNameAr = lastNameAr,
                        LastNameEn = lastNameEn,
                        Phone = phone,
                    };

                    await _userRepository.Add(domainUser);

                    identityUser.DomainUserId = domainUser.Id;
                    await _userManager.UpdateAsync(identityUser);

                    await _signInManager.SignInAsync(identityUser, isPersistent: false);

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

        public async Task<bool> LoginAsync(string email, string password, bool rememberMe)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, rememberMe, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var user = await _userRepository.GetUserByEmailAsync(email);
                if (user != null)
                {
                    user.LastLoginAt = DateTime.UtcNow;
                    await _userRepository.Update(user);
                }
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