using ECommerce.Application.DTOs;

namespace ECommerce.Application.Interfaces.services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetAllAsync();

        Task<CategoryDto?> GetByIdAsync(int id);

        Task<CategoryDto> CreateAsync(CreateCategoryDto dto);

        Task<CategoryDto> UpdateAsync(UpdateCategoryDto dto);

        Task DeleteAsync(int id);
    }
}