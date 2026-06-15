
using ECommerce.Application.DTOs.Dashboard;
using ECommerce.Application.DTOs.Home;
using ECommerce.Application.DTOs.Products;

namespace ECommerce.Application.Interfaces
{
    public interface IHomeService
    {
        public Task<HomeDto> GetHomeDataAsync();
        public Task<DashboardDto> GetDashboardDateAsync();
        public Task<List<ProductDto>> GetSearchedProductAsync(string name ,int? categoryId, decimal? minPrice , decimal? maxPrice , bool inStockOnly = false);
    }
}