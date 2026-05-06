using System.ComponentModel.DataAnnotations;

namespace ECommerce.Domain.Entities.Base
{
    public class BaseEntity : BaseMetadataEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
