using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.User
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters.")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "First Name (EN) is required.")]
        [StringLength(50, ErrorMessage = "First Name (EN) cannot exceed 50 characters.")]
        [RegularExpression(@"^(?=.*[a-zA-Z])[\x20-\x7E]+$", ErrorMessage = "The First Name must contain at least one English letter, and use only English letters, numbers, and symbols.")]
        public string FirstNameEn { get; set; } = null!;
        [Required(ErrorMessage = "Middle Name (EN) is required.")]
        [StringLength(50, ErrorMessage = "Middle Name (EN) cannot exceed 50 characters.")]
        [RegularExpression(@"^(?=.*[a-zA-Z])[\x20-\x7E]+$", ErrorMessage = "The Middle Name must contain at least one English letter, and use only English letters, numbers, and symbols.")]
        public string MiddleNameEn { get; set; } = null!;

        [Required(ErrorMessage = "Last Name (EN) is required.")]
        [StringLength(50, ErrorMessage = "Last Name (EN) cannot exceed 50 characters.")]
        [RegularExpression(@"^(?=.*[a-zA-Z])[\x20-\x7E]+$", ErrorMessage = "The Last Name must contain at least one English letter, and use only English letters, numbers, and symbols.")]
        public string LastNameEn { get; set; } = null!;

        [Required(ErrorMessage = "الاسم الأول مطلوب.")]
        [StringLength(50, ErrorMessage = "الاسم الأول لا يمكن أن يتجاوز 50 حرفاً.")]
        [RegularExpression(@"^[\u0600-\u06FF\s]+$", ErrorMessage = "يجب إدخال الاسم الأول باللغة العربية فقط.")]
        public string FirstNameAr { get; set; } = null!;
        [Required(ErrorMessage = "اسم الأب مطلوب.")]
        [StringLength(50, ErrorMessage = "اسم الأب لا يمكن أن يتجاوز 50 حرفاً.")]
        [RegularExpression(@"^[\u0600-\u06FF\s]+$", ErrorMessage = "يجب إدخال اسم الأب باللغة العربية فقط.")]
        public string MiddleNameAr { get; set; } = null!;

        [Required(ErrorMessage = "اسم العائلة مطلوب.")]
        [StringLength(50, ErrorMessage = "اسم العائلة لا يمكن أن يتجاوز 50 حرفاً.")]
        [RegularExpression(@"^[\u0600-\u06FF\s]+$", ErrorMessage = "يجب إدخال اسم العائلة باللغة العربية فقط.")]
        public string LastNameAr { get; set; } = null!;

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters.")]
        public string Phone { get; set; } = null!;

        public bool IsActive { get; set; } = true;

        public bool IsEmailVerified { get; set; } = false;

        [Required(ErrorMessage = "Please assign a role.")]
        public int RoleId { get; set; }
    }
}