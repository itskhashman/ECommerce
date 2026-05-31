using AutoMapper;
using ECommerce.Application.DTOs.Lookups;
using ECommerce.Application.DTOs.ProductImage;
using ECommerce.Application.DTOs.Products;
using ECommerce.Application.DTOs.ProductVariant;
using ECommerce.Application.DTOs.ProductVariantOption;
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
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();

            CreateMap<CreateProductDto, Product>();
            CreateMap<CreateProductVariantDto, ProductVariant>();
            CreateMap<CreateProductVariantOptionDto, ProductVariantOptions>();

            CreateMap<UpdateProductDto, Product>();

            CreateMap<ProductVariantDto, ProductVariant>().ReverseMap();
            CreateMap<ProductVariantOptionsDto, ProductVariantOptions>().ReverseMap();
            CreateMap<ProductImageDto, ProductImage>().ReverseMap();

            CreateMap<DiscountType, DiscountTypeDto>().ReverseMap();

            CreateMap<ProductDto, UpdateProductDto>();

        }
    }
}