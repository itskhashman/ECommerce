using AutoMapper;
using ECommerce.Application.DTOs.Cart;
using ECommerce.Application.DTOs.Lookups;
using ECommerce.Application.DTOs.ProductImage;
using ECommerce.Application.DTOs.Products;
using ECommerce.Application.DTOs.ProductVariant;
using ECommerce.Application.DTOs.ProductVariantOption;
using ECommerce.Application.DTOs.Sku;
using ECommerce.Application.DTOs.Wishlist;
using ECommerce.Domain.Entities.Products;
using ECommerce.Domain.Entities.Products.Lookups;
using ECommerce.Domain.Entities.Users;

namespace ECommerce.Application.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<ProductVariant, ProductVariantDto>().ReverseMap();
            CreateMap<ProductVariantOptions, ProductVariantOptionsDto>().ReverseMap();
            CreateMap<ProductImage, ProductImageDto>().ReverseMap();

            CreateMap<Sku, SkuDto>();

            CreateMap<SKUProductVariantOptions, SKUProductVariantOptionsDto>();

            CreateMap<DiscountType, DiscountTypeDto>().ReverseMap();

            CreateMap<CreateProductDto, Product>()
                .ForMember(dest => dest.ProductVariants, opt => opt.Ignore())
                .ForMember(dest => dest.Skus, opt => opt.Ignore())
                .ForMember(dest => dest.ProductImages, opt => opt.Ignore());

            CreateMap<UpdateProductDto, Product>().ReverseMap();
            CreateMap<ProductDto, UpdateProductDto>().ReverseMap();

            CreateMap<CreateProductVariantDto, ProductVariant>();
            CreateMap<CreateProductVariantOptionDto, ProductVariantOptions>();
            CreateMap<CreateSkuDto, Sku>();

            CreateMap<WishlistDto, Wishlist>().ReverseMap();
            CreateMap<WishlistItemDto, WishlistItem>().ReverseMap();

            CreateMap<Cart, CartDto>();

            CreateMap<CartItem, CartItemDto>();

        }
    }
}