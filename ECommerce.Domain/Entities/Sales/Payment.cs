

using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Sales.Lookups;
using ECommerce.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Sales
{
    public class Payment : BaseEntity
    {
        [Required, MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string TransactionId { get; set; } = null!;
        [Required]
        [ForeignKey("PaymentMethod")]
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; } = null!;
        [Required]
        [ForeignKey("PaymentStatus")]
        public int PaymentStatusId { get; set; }
        public PaymentStatus PaymentStatus { get; set; } = null!;
        public DateTime? PaidAt { get; set; }

    }

}
