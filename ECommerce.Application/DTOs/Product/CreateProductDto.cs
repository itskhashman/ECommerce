using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs.Products
{
    public class CreateProductDto : BaseDto
    {
        [Required(ErrorMessage = "Please select a main category")]
        public int MainCategoryId { get; set; }

        [Required(ErrorMessage = "Please select a subcategory")]
        public int CategoryId { get; set; }
        [RegularExpression(@"^[\u0600-\u06FF\s]+$", ErrorMessage = "يجب إدخال الاسم بالحروف العربية فقط")]

        [Required(ErrorMessage = "Name (Arabic) is required")]
        [MaxLength(30)]
        public string NameAr { get; set; } = null!;

        [Required(ErrorMessage = "Name (English) is required")]
        [MaxLength(30)]
        public string NameEn { get; set; } = null!;

        [Required(ErrorMessage = "Description (Arabic) is required")]
        [RegularExpression(@"^[\u0600-\u06FF\s]+$", ErrorMessage = "يجب إدخال الاسم بالحروف العربية فقط")]
        public string DescriptionAr { get; set; } = null!;

        [Required(ErrorMessage = "Description (English) is required")]
        public string DescriptionEn { get; set; } = null!;
        public List<IFormFile>? ImageFiles { get; set; }
        public int? DiscountTypeId { get; set; }
        public string? DiscountTypeName { get; set; }
        public decimal? DiscountAmount { get; set; }

        public bool IsActive { get; set; } = true;

        /*
        public ICollection<ProductImageDto> ProductImages { get; set; } = new List<ProductImageDto>();
        public ICollection<ProductVariantDto> ProductVariants { get; set; } = new List<ProductVariantDto>();
        public ICollection<SkuDto> Skus { get; set; } = new List<SkuDto>();
        */
    }
}