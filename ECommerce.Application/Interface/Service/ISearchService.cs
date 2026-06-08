
using ECommerce.Application.DTOs.Products;

namespace ECommerce.Application.Interfaces
{
    public interface ISearchService
    {
        public Task<List<ProductDto>> GetSearchedProductAsync(string name ,int? categoryId, decimal? minPrice , decimal? maxPrice , bool inStockOnly = false);
    }
}