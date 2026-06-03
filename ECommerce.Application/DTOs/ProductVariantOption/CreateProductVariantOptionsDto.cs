using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.ProductVariantOption
{
    public class CreateProductVariantOptionDto
    {
        [Required]
        public string NameEn { get; set; } = null!;
        [Required]
        public string NameAr { get; set; } = null!;
        public int SortOrder { get; set; }
    }
}