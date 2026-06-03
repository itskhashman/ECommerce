using ECommerce.Application.DTOs.Products;


namespace ECommerce.Application.DTOs.ProductVariant.SimpleVariant
{
    public class SimpleVariantDto
    {
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public List<SimpleOptionDto> Options { get; set; } = new List<SimpleOptionDto>();
    }

}