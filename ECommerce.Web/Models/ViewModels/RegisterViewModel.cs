using System.ComponentModel.DataAnnotations;

namespace ECommerce.Web.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; } = null!;

        [Required, DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; } = null!;

        public string FirstNameEn { get; set; } = null!;
        public string MiddleNameEn { get; set; } = null!;
        public string LastNameEn { get; set; } = null!;
        public string FirstNameAr { get; set; } = null!;
        public string MiddleNameAr { get; set; } = null!;
        public string LastNameAr { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
