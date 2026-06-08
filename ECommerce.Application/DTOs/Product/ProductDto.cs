using ECommerce.Application.DTOs.Lookups;
using ECommerce.Application.DTOs.ProductImage;
using ECommerce.Application.DTOs.ProductVariant;
using ECommerce.Application.DTOs.ProductVariant.NestedVariant;
using ECommerce.Application.DTOs.ProductVariant.SimpleVariant;
using ECommerce.Application.DTOs.Sku;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.Products
{
    public class ProductDto : BaseDto
    {
        public int CategoryId { get; set; }
        public string? CategoryNameEn { get; set; }
        public string? CategoryNameAr { get; set; }

        [Required]
        [MaxLength(30)]
        public string NameAr { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string NameEn { get; set; } = null!;

        [Required]
        public string DescriptionAr { get; set; } = null!;

        [Required]
        public string DescriptionEn { get; set; } = null!;

        public int? DiscountTypeId { get; set; }
        public DiscountTypeDto? DiscountType { get; set; }
        public decimal? DiscountAmount { get; set; }

        public bool IsActive { get; set; } = true;
        public bool HasNestedVariants { get; set; }
        public ICollection<ProductImageDto> ProductImages { get; set; } = new List<ProductImageDto>();
        public ICollection<ProductVariantDto> ProductVariants { get; set; } = new List<ProductVariantDto>();
        public List<SimpleVariantDto> SimpleProductVariants { get; set; } = new();
        public List<NestedVariantDto> NestedProductVariants { get; set; } = new();
        public ICollection<SkuDto> Skus { get; set; } = new List<SkuDto>();
    }
}