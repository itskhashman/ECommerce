using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Products
{
    public class ProductVariantOptions : BaseEntity
    {
        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; } = null!;
        [MaxLength(30)]
        [Required]
        public string NameAr { get; set; } = null!;
        [MaxLength(30)]
        [Required]
        public string NameEn { get; set; } = null!;
        public int? SortOrder { get; set; }
        public string? HexColor { get; set; }
    }
}
