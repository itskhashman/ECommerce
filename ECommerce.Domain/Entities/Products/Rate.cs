using ECommerce.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Products
{
    public class Rate : BaseEntity
    {
        [Required]
        public decimal Value { get; set; }
        [Required]
        public int ReviewCount { get; set; }
    }
}
