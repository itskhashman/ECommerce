using AutoMapper;
using ECommerce.Application.DTOs.Lookups;
using ECommerce.Application.DTOs.ProductImage;
using ECommerce.Application.DTOs.Products;
using ECommerce.Application.DTOs.ProductVariant;
using ECommerce.Application.DTOs.ProductVariantOption;
using ECommerce.Application.DTOs.Sku;
using ECommerce.Domain.Entities.Products;
using ECommerce.Domain.Entities.Products.Lookups;

namespace ECommerce.Application.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.CategoryNameEn, opt => opt.MapFrom(src => src.Category != null ? src.Category.NameEn : string.Empty))
                .ForMember(dest => dest.CategoryNameAr, opt => opt.MapFrom(src => src.Category != null ? src.Category.NameAr : string.Empty));

            CreateMap<ProductVariant, ProductVariantDto>();
            CreateMap<ProductVariantOptions, ProductVariantOptionsDto>();
            CreateMap<ProductImage, ProductImageDto>().ReverseMap();


            CreateMap<Sku, SkuDto>()
                .ForMember(dest => dest.SKUJoinOptions, opt => opt.MapFrom(src =>
                    src.SKUJoinOptions != null
                        ? src.SKUJoinOptions.Select(join => join.ProductVariantOptions)
                        : new List<ProductVariantOptions>()));

            CreateMap<DiscountType, DiscountTypeDto>().ReverseMap();

            CreateMap<CreateProductDto, Product>()
                .ForMember(dest => dest.ProductVariants, opt => opt.Ignore())
                .ForMember(dest => dest.Skus, opt => opt.Ignore())
                .ForMember(dest => dest.ProductImages, opt => opt.Ignore());

            CreateMap<UpdateProductDto, Product>().ReverseMap();
            CreateMap<ProductDto, UpdateProductDto>();

            CreateMap<CreateProductVariantDto, ProductVariant>();
            CreateMap<CreateProductVariantOptionDto, ProductVariantOptions>();
            CreateMap<CreateSkuDto, Sku>();
        }
    }
}