using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Base
{
    public class BaseEntity : AuditableEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
