using AutoMapper;
using ECommerce.Application.DTOs.Products;
using ECommerce.Domain.Entities.Products;

namespace ECommerce.Application.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();

            CreateMap<CreateProductDto, Product>();

            CreateMap<UpdateProductDto, Product>();
        }
    }
}