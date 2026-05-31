using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.ProductImage
{
    public class ProductImageDto : BaseDto
    {
        public int ProductId { get; set; }
        [Required]
        public string URL { get; set; } = null!;
        [Required]
        public bool IsMain { get; set; }
        [MaxLength(30)]
        public string? AltText { get; set; }
        public int? SortOrder { get; set; }

    }
}