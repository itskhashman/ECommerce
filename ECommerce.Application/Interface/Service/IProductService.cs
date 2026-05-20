using ECommerce.Application.DTOs.Products;

namespace ECommerce.Application.Interfaces.services
{
    public interface IProductService
    {
            Task<IEnumerable<ProductDto>> GetAllByCategoryIdAsync(int categoryId);
            Task<ProductDto?> GetByIdAsync(int id);
            Task<ProductDto> CreateAsync(CreateProductDto product);
            Task<ProductDto> UpdateAsync(UpdateProductDto product);
            Task DeleteAsync(int id);
    }
}