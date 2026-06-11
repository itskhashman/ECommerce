using System.ComponentModel.DataAnnotations;

namespace ECommerce.Web.Models.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters.")]
        [RegularExpression(@"^[a-zA-Z0-StringLength0-9_.-]+$", ErrorMessage = "Username can only contain letters, numbers, underscores, hyphens, and periods.")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string Password { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirming your password is required.")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = null!;


        [Required(ErrorMessage = "First Name (EN) is required.")]
        [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "First Name (EN) can only contain English letters.")]
        public string FirstNameEn { get; set; } = null!;

        [Required(ErrorMessage = "Middle Name (EN) is required.")]
        [StringLength(50, ErrorMessage = "Middle Name cannot exceed 50 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Middle Name (EN) can only contain English letters.")]
        public string MiddleNameEn { get; set; } = null!;

        [Required(ErrorMessage = "Last Name (EN) is required.")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Last Name (EN) can only contain English letters.")]
        public string LastNameEn { get; set; } = null!;


        [Required(ErrorMessage = "الاسم الأول مطلوب.")]
        [StringLength(50, ErrorMessage = "الاسم الأول لا يمكن أن يتجاوز 50 حرفاً.")]
        [RegularExpression(@"^[\u0621-\u064A\s]+$", ErrorMessage = "الاسم الأول يجب أن يكون بالحروف العربية فقط.")]
        public string FirstNameAr { get; set; } = null!;

        [Required(ErrorMessage = "اسم الأب مطلوب.")]
        [StringLength(50, ErrorMessage = "اسم الأب لا يمكن أن يتجاوز 50 حرفاً.")]
        [RegularExpression(@"^[\u0621-\u064A\s]+$", ErrorMessage = "اسم الأب يجب أن يكون بالحروف العربية فقط.")]
        public string MiddleNameAr { get; set; } = null!;

        [Required(ErrorMessage = "اسم العائلة مطلوب.")]
        [StringLength(50, ErrorMessage = "اسم العائلة لا يمكن أن يتجاوز 50 حرفاً.")]
        [RegularExpression(@"^[\u0621-\u064A\s]+$", ErrorMessage = "اسم العائلة يجب أن يكون بالحروف العربية فقط.")]
        public string LastNameAr { get; set; } = null!;


        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Please enter a valid phone number structure.")]
        [RegularExpression(@"^\+?[0-9]{7,15}$", ErrorMessage = "Phone number must be between 7 and 15 digits long and can start with a + symbol.")]
        public string Phone { get; set; } = null!;
    }
}