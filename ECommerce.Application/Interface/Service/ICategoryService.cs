using ECommerce.Application.DTOs.Category;
using ECommerce.Application.Service;

namespace ECommerce.Application.Interfaces.services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<IEnumerable<CategoryDto>> GetAllOrderedAsync();
        Task<IEnumerable<CategoryDto>> GetAllMainCategoriesAsync();
        Task<IEnumerable<CategoryDto>> GetAllSubCategoriesAsync();
        Task<IEnumerable<CategoryDto>> GetSubCategoriesByMainCategoryIdAsync(int mainCategoryId);
        Task<CategoryDto?> GetByIdAsync(int id);

        Task<CategoryDto> CreateAsync(CreateCategoryDto dto);

        Task<CategoryDto> UpdateAsync(UpdateCategoryDto dto);

        Task DeleteAsync(int id);
    }
}