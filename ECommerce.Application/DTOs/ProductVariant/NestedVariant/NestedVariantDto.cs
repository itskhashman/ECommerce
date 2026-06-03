namespace ECommerce.Application.DTOs.ProductVariant.NestedVariant
{
    public class NestedVariantDto
    {
        public int Id { get; set; }
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public List<NestedMainOptionDto> Options { get; set; } = new List<NestedMainOptionDto>();
    }
}