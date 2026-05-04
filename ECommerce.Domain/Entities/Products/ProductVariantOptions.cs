using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Products
{
    public class ProductVariantOptions
    {
        [Key]
        public int Id { get; set; }


        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; } = null!;
        [MaxLength(30)]
        [Required]
        public string Name { get; set; } = null!;
    }
}
