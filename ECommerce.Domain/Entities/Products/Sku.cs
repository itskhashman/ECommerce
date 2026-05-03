using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Products
{
    public class Sku
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Product")] 
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }
        [MaxLength(10)]
        public string PriceUnit { get; set; } = null!;
    }
}
