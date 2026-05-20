using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.Category
{

    public class UpdateCategoryDto 
    {
        public int Id { get; set; }
        [RegularExpression(@"^[\u0600-\u06FF\x20-\x40\x5B-\x60\x7B-\x7E]+$", ErrorMessage = "The Name Should contain Arabic letters, numbers, and symbols only")]
        [Required(ErrorMessage = "The Arabic Name is Required")]
        [MaxLength(30)]
        public string NameAr { get; set; } = null!;
        [RegularExpression(@"^(?=.*[a-zA-Z])[\x20-\x7E]+$", ErrorMessage = "The Name must contain at least one English letter, and use only English letters, numbers, and symbols.")]
        [Required(ErrorMessage = "The English Name is Required")]
        [MaxLength(30)]
        public string NameEn { get; set; } = null!;

        [Display(Name = "Category Image")]
        public IFormFile? ImageFile { get; set; }
        public string? ImageUrl { get; set; }

        public int? ParentCategoryId { get; set; }
        [Required(ErrorMessage = "The Category Activity should be choosen")]
        public bool IsActive { get; set; } = true;
    }
}

