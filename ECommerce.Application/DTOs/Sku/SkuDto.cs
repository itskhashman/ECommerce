using ECommerce.Application.DTOs.Products;
using System.ComponentModel.DataAnnotations;


namespace ECommerce.Application.DTOs.Sku
{
    public class SkuDto : BaseDto
    {
        public int ProductId { get; set; }
        public ProductDto Product { get; set; } = null!;
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
        public ICollection<SKUProductVariantOptionsDto>? SKUJoinOptions { get; set; } = new List<SKUProductVariantOptionsDto>();


    }
}