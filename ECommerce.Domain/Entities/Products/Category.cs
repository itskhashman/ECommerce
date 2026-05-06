using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Products
{
    public class Category : BaseEntity
    {
        public string? NameAr { get; set; }
        [Required]
        public string NameEn { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
        [Required]
        public int NumberOfProducts { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
    }
}
