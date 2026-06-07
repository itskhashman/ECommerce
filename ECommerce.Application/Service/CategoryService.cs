using AutoMapper;
using ECommerce.Application.DTOs.Category;
using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interfaces.services;
using ECommerce.Domain.Entities.Products;

namespace ECommerce.Application.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<CategoryDto>>(categories);
        }
        public async Task<IEnumerable<CategoryDto>> GetAllOrderedAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();

            var categoryDto = _mapper.Map<IEnumerable<CategoryDto>>(categories);

            var rootCategories = categoryDto
                .Where(c => c.ParentCategoryId == null)
                .ToList();

            foreach (var parent in rootCategories)
            {
                parent.Children = categoryDto
                    .Where(c => c.ParentCategoryId == parent.Id)
                    .ToList();
            }

            return rootCategories;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllMainCategoriesAsync()
        {
            var parentCategories = await _categoryRepository.GetMainCategoriesAsync();

            return _mapper.Map<IEnumerable<CategoryDto>>(parentCategories);
        }
        public async Task<IEnumerable<CategoryDto>> GetSubCategoriesByMainCategoryIdAsync(int mainCategoryId)
        {
            var subCategories = await _categoryRepository.GetSubCategoriesByMainCategoryIdAsync(mainCategoryId);
            return _mapper.Map<IEnumerable<CategoryDto>>(subCategories);
        }


        public async Task<IEnumerable<CategoryDto>> GetAllSubCategoriesAsync()
        {
            var childCategories = await _categoryRepository.GetSubCategoriesAsync();

            return _mapper.Map<IEnumerable<CategoryDto>>(childCategories);
        }

        public async Task<CategoryDto?> GetByIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIDAsync(id);

            if (category == null)
                return null;

            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> CreateAsync(CreateCategoryDto dto)
        {
            var category = _mapper.Map<Category>(dto);

            var addedCategory = await _categoryRepository.AddAsync(category);

            return _mapper.Map<CategoryDto>(addedCategory);
        }

        public async Task<CategoryDto> UpdateAsync(UpdateCategoryDto dto)
        {
            var category = await _categoryRepository.GetByIDAsync(dto.Id);

            if (category == null)
                throw new Exception("Category not found");

            _mapper.Map(dto, category);

            var updatedCategory = await _categoryRepository.UpdateAsync(category);
            return _mapper.Map<CategoryDto>(updatedCategory);
        }

        public async Task DeleteAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }
    }
}