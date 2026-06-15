using ECommerce.Application.DTOs.Lookups;
using ECommerce.Application.DTOs.Products;

namespace ECommerce.Application.Interfaces.services
{
    public interface IProductService
    {
        Task<int?> GetTotalProductsAsync();
        Task<Dictionary<int, ProductDto>> GetTopProductsAsync();
        Task<IEnumerable<ProductDto>?> GetNewestProductsAsync();
        Task<IEnumerable<ProductDto>> GetAllByCategoryIdAsync(int categoryId);
        Task<IEnumerable<ProductDto>> GetAllProductsWithMainImageAsync();
        Task<IEnumerable<DiscountTypeDto>> GetDiscountTypesAsync();
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<IEnumerable<ProductDto>> GetProductsByNameAsync(string name,int? categoryId, decimal? minPrice, decimal? maxPrice, bool inStockOnly = false);
        Task<UpdateProductDto> GetProductWithAllDetailsAsync(int productId);
        Task<ProductDto?> GetByIdAsync(int id);
        Task<ProductDto> CreateAsync(CreateProductDto product);
        Task<ProductDto> CreateProductWithVariantsAsync(CreateProductDto product);
        Task<ProductDto> UpdateAsync(UpdateProductDto product);
        Task DeleteAsync(int id);
    }
}