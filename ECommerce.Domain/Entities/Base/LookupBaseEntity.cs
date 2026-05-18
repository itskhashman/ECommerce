using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Base
{
    public class LookupBaseEntity : BaseEntity
    {
        [MaxLength(50)]
        [Required]
        public string NameAr { get; set; } = null!;
        [MaxLength(50)]
        [Required]
        [Column(TypeName = "varchar")]
        public string NameEn { get; set; } = null!;
        public string? DescriptionAr { get; set; }
        [Column(TypeName = "varchar(max)")]
        public string? DescriptionEn { get; set; }
    }
}