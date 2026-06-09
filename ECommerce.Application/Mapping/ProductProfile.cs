using AutoMapper;
using ECommerce.Application.DTOs.Address;
using ECommerce.Application.DTOs.Cart;
using ECommerce.Application.DTOs.Lookups;
using ECommerce.Application.DTOs.Order;
using ECommerce.Application.DTOs.ProductImage;
using ECommerce.Application.DTOs.Products;
using ECommerce.Application.DTOs.ProductVariant;
using ECommerce.Application.DTOs.ProductVariantOption;
using ECommerce.Application.DTOs.Sku;
using ECommerce.Application.DTOs.User;
using ECommerce.Application.DTOs.Wishlist;
using ECommerce.Domain.Entities.Products;
using ECommerce.Domain.Entities.Products.Lookups;
using ECommerce.Domain.Entities.Sales;
using ECommerce.Domain.Entities.Sales.Lookups;
using ECommerce.Domain.Entities.Users;
using ECommerce.Domain.Entities.Users.Lookups;

namespace ECommerce.Application.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();

            CreateMap<ProductVariant, ProductVariantDto>().ReverseMap();
            CreateMap<ProductVariantOptions, ProductVariantOptionsDto>().ReverseMap();
            CreateMap<ProductImage, ProductImageDto>().ReverseMap();

            CreateMap<Sku, SkuDto>().ReverseMap();

            CreateMap<SKUProductVariantOptions, SKUProductVariantOptionsDto>().ReverseMap();

            CreateMap<DiscountType, DiscountTypeDto>().ReverseMap();
            CreateMap<OrderStatus, OrderStatusDto>().ReverseMap();
            CreateMap<PaymentMethod, PaymentMethodDto>().ReverseMap();
            CreateMap<PaymentStatus, PaymentStatusDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();

            CreateMap<CreateProductDto, Product>().ReverseMap();

            CreateMap<UpdateProductDto, Product>().ReverseMap();
            CreateMap<ProductDto, UpdateProductDto>().ReverseMap();

            CreateMap<CreateProductVariantDto, ProductVariant>().ReverseMap();
            CreateMap<CreateProductVariantOptionDto, ProductVariantOptions>().ReverseMap();
            CreateMap<CreateSkuDto, Sku>().ReverseMap();

            CreateMap<WishlistDto, Wishlist>().ReverseMap();
            CreateMap<WishlistItemDto, WishlistItem>().ReverseMap();

            CreateMap<Cart, CartDto>().ReverseMap();
            CreateMap<CartItem, CartItemDto>().ReverseMap();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UpdateUserDto, User>().ReverseMap();

            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();

            CreateMap<Payment, PaymentDto>().ReverseMap();

            CreateMap<ShippingRate, ShippingRateDto>().ReverseMap();

            CreateMap<Address, AddressDto>().ReverseMap();


        }
    }
}