

namespace ECommerce.Domain.Entities.Products
{
    public class SKUProductVariantOptions
    {

        public int SkuId { get; set; }
        public Sku Sku { get; set; } = null!;
        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; } = null!;
        public int ProductVariantOptionsId { get; set; }
        public ProductVariantOptions ProductVariantOptions { get; set; } = null!;

    }
}
