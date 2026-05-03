using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Products
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public ICollection<ProductImage>? ProductImages { get; set; } = new List<ProductImage>();

        public ICollection<ProductVariant>? ProductVariants { get; set; } = new List<ProductVariant>();
        public ICollection<Sku>? Skus { get; set; } = new List<Sku>();
        [Required]
        public int Stock { get; set; }
        public decimal? Rating { get; set; }
        public int? ReviewCount { get; set; }
        [Required]
        public decimal DefaultPrice { get; set; }
        public decimal? DiscountAmount { get; set; }
        [MaxLength(15)]
        public string? DiscountType { get; set; }


    }
}
