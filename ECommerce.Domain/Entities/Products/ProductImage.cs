using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Products
{
    public class ProductImage : BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        [Required]
        [Column(TypeName = "varchar(max)")]
        public string URL { get; set; } = null!;
        [Required]
        public bool IsMain { get; set; }
        [MaxLength(30)]
        [Column(TypeName = "varchar")]
        public string? AltText { get; set; } = null!;
        public int? SortOrder { get; set; }

    }
}
}