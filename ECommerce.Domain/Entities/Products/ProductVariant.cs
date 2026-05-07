using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Products
{
    public class ProductVariant : BaseEntity
    {

        [MaxLength(50)]
        public string? NameAr { get; set; }
        [MaxLength(50)]
        [Required]
        public string NameEn { get; set; } = null!;
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public ICollection<ProductVariantOptions> ProductVariantOptions { get; set; } = new List<ProductVariantOptions>();
        public ICollection<SKUProductVariantOptions> SKUJoinOptions { get; set; } = new List<SKUProductVariantOptions>();

    }
}
