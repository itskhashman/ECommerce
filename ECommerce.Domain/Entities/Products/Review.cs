using ECommerce.Domain.Entities.Base;
using ECommerce.Domain.Entities.Products;
using ECommerce.Domain.Entities.Sales;
using ECommerce.Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Review : BaseEntity
{
    [Required]
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    [Required]
    [ForeignKey("OrderItem")]
    public int OrderItemId { get; set; }
    public OrderItem OrderItem { get; set; } = null!;
    [Required]
    public decimal RatingValue { get; set; }
    public string? Comment { get; set; } 
}