using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Products
{
    public class ProductVariant : BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        [MaxLength(30)]
        [Required]
        public string NameAr { get; set; } = null!;
        [MaxLength(30)]
        [Required]
        [Column(TypeName = "varchar")]
        public string NameEn { get; set; } = null!;
        [Required]
        public ICollection<ProductVariantOptions> ProductVariantOptions { get; set; } = new List<ProductVariantOptions>();

    }
}