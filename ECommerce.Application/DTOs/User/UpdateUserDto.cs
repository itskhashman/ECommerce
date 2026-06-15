using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.User
{
    public class UpdateUserDto : BaseDto
    {
        [Required(ErrorMessage = "First Name (EN) is required.")]
        [StringLength(50, ErrorMessage = "First Name (EN) cannot exceed 50 characters.")]
        public string FirstNameEn { get; set; } = null!;
        [Required(ErrorMessage = "Middle Name (EN) is required.")]
        [StringLength(50, ErrorMessage = "Middle Name (EN) cannot exceed 50 characters.")]
        public string MiddleNameEn { get; set; } = null!;

        [Required(ErrorMessage = "Last Name (EN) is required.")]
        [StringLength(50, ErrorMessage = "Last Name (EN) cannot exceed 50 characters.")]
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
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        [StringLength(100, ErrorMessage = "Email cannot exceed 100 characters.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15  characters.")]
        public string Phone { get; set; } = null!;

        [Required(ErrorMessage = "Account active status must be specified.")]
        public bool? IsActive { get; set; }

        [Required(ErrorMessage = "Email status confirmation is required.")]
        public bool? IsEmailVerified { get; set; }

        [Required(ErrorMessage = "Please assign a system role.")]
        public int? RoleId { get; set; }
    }
}