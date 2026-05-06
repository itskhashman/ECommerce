using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Products
{
    public class ProductVariantOptions : BaseEntity
    {
        [MaxLength(30)]
        public string? NameAr { get; set; }
        [MaxLength(30)]
        [Required]
        public string NameEn { get; set; } = null!;
        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; } = null!;

    }
}
