using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Products
{
    public class Category : BaseEntity
    {
        [Required]
        [ForeignKey("ParentCategory")]
        public int ParentCategoryId { get; set; }
        public Category ? ParentCategory { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        public string NameAr { get; set; } = null!;

        [Required]
        public string NameEn { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public bool IsActive { get; set; } = true;
    }
}
