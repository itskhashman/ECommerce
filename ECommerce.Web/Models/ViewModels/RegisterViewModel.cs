using System.ComponentModel.DataAnnotations;

namespace ECommerce.Web.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Username is required.")]
        public string Username { get; set; } = null!;
        [Required(ErrorMessage = "Email is required."), EmailAddress]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is required."), DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password), Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = null!;
        [Required]
        public string FirstNameEn { get; set; } = null!;
        [Required]
        public string MiddleNameEn { get; set; } = null!;
        public string LastNameEn { get; set; } = null!;
        public string FirstNameAr { get; set; } = null!;
        public string MiddleNameAr { get; set; } = null!;
        public string LastNameAr { get; set; } = null!;
        public string Phone { get; set; } = null!;
    }
}
