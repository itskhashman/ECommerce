namespace ECommerce.Application.DTOs.ProductVariant.NestedVariant
{
    public class NestedSubOptionDto : BaseDto
    {
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}