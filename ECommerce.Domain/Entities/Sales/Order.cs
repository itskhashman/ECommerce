

using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Sales.Lookups;
using ECommerce.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entities.Sales
{
    public class Order : BaseEntity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        [Required]
        [MaxLength(20)]
        public string OrderNumber { get; set; } = null!;
        [Required]
        public decimal TotalAmount { get; set; }
        [Required]
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; } = null!;
        [Required]
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; } = null!;
        [Required]
        public string CurrencyCode { get; set; } = null!;
        [Required]
        public decimal ShippingCost { get; set; }
        public string? Notes { get; set; }
        [Required]
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }

}
