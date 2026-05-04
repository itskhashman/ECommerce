using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Products
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
