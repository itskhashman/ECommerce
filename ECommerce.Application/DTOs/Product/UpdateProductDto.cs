using ECommerce.Application.DTOs.ProductImage;
using ECommerce.Application.DTOs.ProductVariant;
using ECommerce.Application.DTOs.Sku;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.Products
{
    public class UpdateProductDto : BaseDto
    {

        [Required(ErrorMessage = "Please select a main category")]
        public int MainCategoryId { get; set; }

        [Required(ErrorMessage = "Please select a subcategory")]
        public int CategoryId { get; set; }

        [RegularExpression(@"^[\u0600-\u06FF\x20-\x40\x5B-\x60\x7B-\x7E]+$", ErrorMessage = "The Name Should contain Arabic letters, numbers, and symbols only")]
        [Required(ErrorMessage = "Name (Arabic) is required")]
        [MaxLength(30)]
        public string NameAr { get; set; } = null!;

        [RegularExpression(@"^(?=.*[a-zA-Z])[\x20-\x7E]+$", ErrorMessage = "The Name must contain at least one English letter, and use only English letters, numbers, and symbols.")]
        [Required(ErrorMessage = "Name (English) is required")]
        [MaxLength(30)]
        public string NameEn { get; set; } = null!;

        [RegularExpression(@"^[\u0600-\u06FF\x20-\x40\x5B-\x60\x7B-\x7E]+$", ErrorMessage = "The Description Should contain Arabic letters, numbers, and symbols only")]
        [Required(ErrorMessage = "Description (Arabic) is required")]
        public string DescriptionAr { get; set; } = null!;

        [RegularExpression(@"^(?=.*[a-zA-Z])[\x20-\x7E]+$", ErrorMessage = "The Description must contain at least one English letter, and use only English letters, numbers, and symbols.")]
        [Required(ErrorMessage = "Description (English) is required")]
        public string DescriptionEn { get; set; } = null!;

        public List<IFormFile>? ImageFiles { get; set; }

        public int? DiscountTypeId { get; set; }
        public string? DiscountTypeName { get; set; }
        public decimal? DiscountAmount { get; set; }
        public bool IsActive { get; set; } = true;

        public List<ProductVariantDto> ProductVariants { get; set; } = new();
        public ICollection<ProductImageDto> ProductImages { get; set; } = new List<ProductImageDto>();
        public ICollection<SkuDto> Skus { get; set; } = new List<SkuDto>();
    }
}