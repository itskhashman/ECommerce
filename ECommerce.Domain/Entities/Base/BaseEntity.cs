using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Base
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [EmailAddress]
        [Required]
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [EmailAddress]
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
    }
}
