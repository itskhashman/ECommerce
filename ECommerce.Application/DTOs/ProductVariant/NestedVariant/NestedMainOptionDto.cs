namespace ECommerce.Application.DTOs.ProductVariant.NestedVariant
{
    public class NestedMainOptionDto : BaseDto
    {
        public string NameEn { get; set; } = null!;
        public string NameAr { get; set; } = null!;
        public List<NestedSubVariantDto> SubVariants { get; set; } = new List<NestedSubVariantDto>();
    }

}