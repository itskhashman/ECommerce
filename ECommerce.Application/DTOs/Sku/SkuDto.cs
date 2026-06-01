using ECommerce.Application.DTOs.ProductVariantOption;
using System.ComponentModel.DataAnnotations;


namespace ECommerce.Application.DTOs.Sku
{
    public class SkuDto : BaseDto
    {
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string SkuCode { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        public decimal? Weight { get; set; }
        public int? LowStockThreshold { get; set; }
        public ICollection<ProductVariantOptionsDto>? SKUJoinOptions { get; set; } = new List<ProductVariantOptionsDto>();


    }
}