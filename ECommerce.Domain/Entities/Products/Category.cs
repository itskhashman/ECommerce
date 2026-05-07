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
        public int NumberOfProducts { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
