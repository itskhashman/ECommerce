using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Base
{
    public abstract class BaseMetadataEntityDto
    {
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int? ModifiedBy { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}