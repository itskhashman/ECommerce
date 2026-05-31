using ECommerce.Application.DTOs.ProductVariantOption;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.ProductVariant
{
    public class ProductVariantDto : BaseDto
    {
        public int ProductId { get; set; }
        [Required]
        [MaxLength(30)]
        public string NameAr { get; set; } = null!;
        [MaxLength(30)]
        [Required]
        public string NameEn { get; set; } = null!;
        public List<ProductVariantOptionsDto> ProductVariantOptions { get; set; } = new List<ProductVariantOptionsDto>();


    }
}