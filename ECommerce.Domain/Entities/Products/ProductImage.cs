using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Products
{   
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string URL { get; set; } = null!;
        [Required]
        public bool IsMain { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

    }
}
