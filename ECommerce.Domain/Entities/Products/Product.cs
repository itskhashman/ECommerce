using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Products.Lookups;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Products
{
    public class Product : BaseEntity
    {
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        [MaxLength(30)]
        [Required]
        public string NameAr { get; set; } = null!;
        [MaxLength(30)]
        [Required]
        public string NameEn { get; set; } = null!;
        [Required]
        public string DescriptionAr { get; set; } = null!;
        [Required]
        public string DescriptionEn { get; set; } = null!;
        [Required]
        [ForeignKey("DiscountType")]
        public int DiscountTypeId { get; set; }
        public DiscountType DiscountType { get; set; } = null!;
        public decimal? DiscountAmount { get; set; }
        [ForeignKey("Rate")]
        public int? RateId { get; set; }
        public Rate? Rate { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<ProductImage>? ProductImages { get; set; } = new List<ProductImage>();
        public ICollection<ProductVariant>? ProductVariants { get; set; } = new List<ProductVariant>();
        public ICollection<Sku>? Skus { get; set; } = new List<Sku>();
    }
}
