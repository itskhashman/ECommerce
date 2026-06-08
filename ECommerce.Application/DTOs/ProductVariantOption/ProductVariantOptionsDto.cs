using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.ProductVariantOption
{
    public class ProductVariantOptionsDto : BaseDto
    {
        [Required]
        public int ProductVariantId { get; set; }
        [Required]
        [MaxLength(30)]
        public string NameAr { get; set; } = null!;
        [MaxLength(30)]
        [Required]
        public string NameEn { get; set; } = null!;
        public int? SortOrder { get; set; }
        [MaxLength(8)]
        public string? HexColor { get; set; }

    }
}