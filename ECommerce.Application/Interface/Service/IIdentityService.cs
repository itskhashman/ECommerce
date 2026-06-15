

using ECommerce.Application.DTOs.User;

namespace ECommerce.Application.Interface.Service
{
    public interface IIdentityService
    {
        Task<bool> RegisterAsync(
                string username, string email, string password,
                string firstNameAr, string middleNameAr, string lastNameAr,
                string firstNameEn, string middleNameEn, string lastNameEn,
                string phone, int roleId, string roleName);
        public Task<bool> DeleteAsync(int userId);
        public Task<bool> LoginAsync(string email, string password, bool rememberMe);
        public Task LogoutAsync();

    }
}
