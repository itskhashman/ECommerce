using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Base
{
    public class LookupBaseEntity : BaseEntity
    {
        [MaxLength(15)]
        [Required]
        public string NameAr { get; set; } = null!;
        [MaxLength(15)]
        [Required]
        public string NameEn { get; set; } = null!;
        [Required]
        public string DescriptionAr { get; set; } = null!;
        [Required]
        public string DescriptionEn { get; set; } = null!;
    }
}
