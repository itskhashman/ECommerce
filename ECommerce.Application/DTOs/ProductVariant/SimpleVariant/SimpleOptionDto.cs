namespace ECommerce.Application.DTOs.ProductVariant.SimpleVariant
{
    public class SimpleOptionDto
    {
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}