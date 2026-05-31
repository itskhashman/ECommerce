

namespace ECommerce.Application.Interface.Service
{
    public interface IIdentityService
    {
        public Task<bool> RegisterAsync(string Username ,string email, string password, string firstNameAr, string middleNameAr, string lastNameAr, string firstNameEn, string middleNameEn, string lastNameEn, string phone);
        public Task<bool> LoginAsync( string email, string password, bool rememberMe);
        public Task LogoutAsync();

    }
}
