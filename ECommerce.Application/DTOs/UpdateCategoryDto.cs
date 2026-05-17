

using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs
{

    public class UpdateCategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Arabic Name is Required")]
        [MaxLength(30)]
        public string NameAr { get; set; } = null!;

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
}
