using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Products
{
    public class Sku : BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string SkuCode { get; set; } = null!;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        public decimal? Weight { get; set; }
        public int? LowStockThreshold { get; set; }
        public ICollection<SKUProductVariantOptions>? SKUJoinOptions { get; set; } = new List<SKUProductVariantOptions>();
    }
}