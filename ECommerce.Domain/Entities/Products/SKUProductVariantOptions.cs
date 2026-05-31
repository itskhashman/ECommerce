using ECommerce.Domain.Entities.Base;

namespace ECommerce.Domain.Entities.Products
{   
    public class SKUProductVariantOptions : BaseEntity
    {

        public int SkuId { get; set; }
        public Sku Sku { get; set; } = null!;
        public int ProductVariantOptionsId { get; set; }
        public ProductVariantOptions ProductVariantOptions { get; set; } = null!;

    }
}
