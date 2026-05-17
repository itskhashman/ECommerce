using ECommerce.Domain.Entities.Users;
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
        [ForeignKey("Creator")]
        public int CreatedBy { get; set; }
        public User? Creator { get; set; } 
        public DateTime? ModifiedAt { get; set; }
        [ForeignKey("Modifier")]
        public int? ModifiedBy { get; set; }
        public User? Modifier { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }
        [ForeignKey("Deleter")]
        public int? DeletedBy { get; set; }
        public User? Deleter { get; set; }
    }
}