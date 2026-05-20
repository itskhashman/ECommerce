using ECommerce.Application.DTOs.Category;

namespace ECommerce.Application.Interfaces.services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();
        Task<IEnumerable<CategoryDto>> GetAllMainCategoriesAsync();
        Task<IEnumerable<CategoryDto>> GetAllSubCategoriesAsync();

        Task<CategoryDto?> GetByIdAsync(int id);

        Task<CategoryDto> CreateAsync(CreateCategoryDto dto);

        Task<CategoryDto> UpdateAsync(UpdateCategoryDto dto);

        Task DeleteAsync(int id);
    }
}