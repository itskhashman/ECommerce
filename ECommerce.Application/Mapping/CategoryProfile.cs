using AutoMapper;
using ECommerce.Application.DTOs.Category;
using ECommerce.Domain.Entities.Products;

namespace ECommerce.Application.Mapping
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>();

            CreateMap<CreateCategoryDto, Category>();

            CreateMap<UpdateCategoryDto, Category>();
        }
    }
}