using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.Base
{
    public class LookupBaseEntityDto : BaseDto
    {
        [MaxLength(50)]
        [Required]
        public string NameAr { get; set; } = null!;
        [MaxLength(50)]
        [Required]
        public string NameEn { get; set; } = null!;
        public string? DescriptionAr { get; set; }
        public string? DescriptionEn { get; set; }
    }
}