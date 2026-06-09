using ECommerce.Application.DTOs.Lookups;

namespace ECommerce.Application.DTOs.Order
{
    public class PaymentDto : BaseDto
    {
        public string TransactionId { get; set; } = null!;
        public int PaymentMethodId { get; set; }
        public PaymentMethodDto PaymentMethod { get; set; } = null!;
        public int PaymentStatusId { get; set; }
        public PaymentStatusDto PaymentStatus { get; set; } = null!;
        public DateTime? PaidAt { get; set; }
    }
}
