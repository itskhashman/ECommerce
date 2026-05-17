using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Base
{
    public abstract class BaseMetadataEntity
    {
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public DateTime ModifiedAt { get; set; }
        [Required]
        public int ModifiedBy { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}