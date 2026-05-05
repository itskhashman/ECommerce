using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Products
{
    public class Category : BaseEntity
    {
        public string? ArName { get; set; }
        [Required]
        public string EnName { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public bool IsActive { get; set; } = true;
    }
}
