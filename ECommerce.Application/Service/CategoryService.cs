using ECommerce.Application.DTOs;
using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interfaces.services;
using ECommerce.Domain.Entities.Products;

namespace ECommerce.Application.Service
{

    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAll();

            return categories.Select(c => new CategoryDto
            {
                Id = c.Id,
                NameAr = c.NameAr,
                NameEn = c.NameEn,
                ImageUrl = c.ImageUrl,
                ParentCategoryId = c.ParentCategoryId,
                IsActive = c.IsActive
            });
        }

        public async Task<CategoryDto?> GetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIDAsync(id);

            if (category == null)
                return null;

            return new CategoryDto
            {
                Id = category.Id,
                NameAr = category.NameAr,
                NameEn = category.NameEn,
                ImageUrl = category.ImageUrl,
                ParentCategoryId = category.ParentCategoryId,
                IsActive = category.IsActive
            };
        }

        public async Task<CategoryDto> CreateAsync(CreateCategoryDto dto)
        {
            var category = new Category
            {
                NameAr = dto.NameAr,
                NameEn = dto.NameEn,
                ImageUrl = dto.ImageUrl,
                ParentCategoryId = dto.ParentCategoryId,
                IsActive = dto.IsActive
            };

            var AddedCategory = await _categoryRepository.Add(category);
            return new CategoryDto
            {
                Id = AddedCategory.Id,
                NameAr = AddedCategory.NameAr,
                NameEn = AddedCategory.NameEn,
                ImageUrl = AddedCategory.ImageUrl,
                ParentCategoryId = AddedCategory.ParentCategoryId,
                IsActive = AddedCategory.IsActive
            };
        }

        public async Task<CategoryDto> UpdateAsync(UpdateCategoryDto dto)
        {
            var category = await _categoryRepository.GetByIDAsync(dto.Id);

            if (category == null)
                throw new Exception("Category not found");

            category.NameAr = dto.NameAr;
            category.NameEn = dto.NameEn;
            category.ImageUrl = dto.ImageUrl;
            category.ParentCategoryId = dto.ParentCategoryId;
            category.IsActive = dto.IsActive;

            var updatedCategory = await _categoryRepository.Update(category);
            return new CategoryDto
            {
                Id = updatedCategory.Id,
                NameAr = updatedCategory.NameAr,
                NameEn = updatedCategory.NameEn,
                ImageUrl = updatedCategory.ImageUrl,
                ParentCategoryId = updatedCategory.ParentCategoryId,
                IsActive = updatedCategory.IsActive
            };
        }

        public async Task DeleteAsync(int id)
        {
            await _categoryRepository.Delete(id);
        }
    }
}