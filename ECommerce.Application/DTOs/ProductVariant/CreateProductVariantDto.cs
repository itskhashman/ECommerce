using ECommerce.Application.DTOs.Products;
using ECommerce.Application.DTOs.ProductVariantOption;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.ProductVariant
{
    public class CreateProductVariantDto
    {
        [Required, MaxLength(30)]
        public string NameEn { get; set; } = null!;
        [Required, MaxLength(30)]
        public string NameAr { get; set; } = null!;
        public List<CreateProductVariantOptionDto> ProductVariantOptions { get; set; } = new();
    }
}