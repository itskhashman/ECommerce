namespace ECommerce.Application.DTOs.ProductVariant.NestedVariant
{
    public class NestedSubVariantDto
    {
        public int Id { get; set; }
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public List<NestedSubOptionDto> SubOptions { get; set; } = new List<NestedSubOptionDto>();
    }
}