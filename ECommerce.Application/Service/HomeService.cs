using ECommerce.Application.DTOs.Home;
using ECommerce.Application.DTOs.Products;
using ECommerce.Application.Interfaces;
using ECommerce.Application.Interfaces.services;


namespace ECommerce.Application.Service
{
    public class HomeService : IHomeService
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        public HomeService(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }
        public async Task<HomeDto> GetHomeDataAsync()
        {
            var categories = await _categoryService.GetAllOrderedAsync();

            var homeData = new HomeDto
            {
                Categories = categories
            };
            return homeData;
        }

        public async Task<List<ProductDto>> GetSearchedProductAsync(string name,int? categoryId, decimal? minPrice, decimal? maxPrice, bool inStockOnly = false)
        {
            var products = await _productService.GetProductsByNameAsync(name, categoryId, minPrice, maxPrice, inStockOnly);
            return products.ToList();
        }
    }
}