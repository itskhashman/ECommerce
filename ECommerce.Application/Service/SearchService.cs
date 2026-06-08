using ECommerce.Application.DTOs.Products;
using ECommerce.Application.Interfaces;
using ECommerce.Application.Interfaces.services;


namespace ECommerce.Application.Service
{
    public class SearchService : ISearchService
    {
        private readonly IProductService _productService;
        public SearchService(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<List<ProductDto>> GetSearchedProductAsync(string name,int? categoryId, decimal? minPrice, decimal? maxPrice, bool inStockOnly = false)
        {
            var products = await _productService.GetProductsByNameAsync(name, categoryId, minPrice, maxPrice, inStockOnly);
            return products.ToList();
        }
    }
}