using ECommerce.Application.DTOs.Dashboard;
using ECommerce.Application.DTOs.Home;
using ECommerce.Application.DTOs.Products;
using ECommerce.Application.Interfaces;
using ECommerce.Application.Interfaces.services;


namespace ECommerce.Application.Service
{
    public class HomeService : IHomeService
    {
        private readonly ICategoryService _categoryService;
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        public HomeService(ICategoryService categoryService, IUserService userService, IOrderService orderService, IProductService productService)
        {
            _categoryService = categoryService;
            _userService = userService;
            _orderService = orderService;
            _productService = productService;
        }
        public async Task<HomeDto> GetHomeDataAsync()
        {
            var categories = await _categoryService.GetAllOrderedAsync();
            var newProducts = await _productService.GetNewestProductsAsync();
            var homeData = new HomeDto
            {
                Categories = categories,
                NewestProducts = newProducts
            };
            return homeData;
        }

        public async Task<List<ProductDto>> GetSearchedProductAsync(string name,int? categoryId, decimal? minPrice, decimal? maxPrice, bool inStockOnly = false)
        {
            var products = await _productService.GetProductsByNameAsync(name, categoryId, minPrice, maxPrice, inStockOnly);
            return products.ToList();
        }

        public async Task<DashboardDto> GetDashboardDateAsync()
        {
            var topProducts = await _productService.GetTopProductsAsync();
            var topCategories = await _categoryService.GetTopCategoriesAsync();

            var dashboardData = new DashboardDto
            {
                TotalUsers = await _userService.GetTotalUsersAsync(),
                TotalSales = await _orderService.GetTotalSalesAsync(),
                TotalOrders = await _orderService.GetTotalOrdersAsync(),
                TotalProducts = await _productService.GetTotalProductsAsync(),
                TotalCategories = await _categoryService.GetTotalCategoriesAsync(), 
                OrdersLastWeek = await _orderService.GetLastWeekOrdersAsync(),
                OrdersPending = await _orderService.GetTotalPendingAsync(),
                OrdersConfirmed = await _orderService.GetTotalConfirmedAsync(),
                OrdersShipped = await _orderService.GetTotalShippedAsync(),
                OrdersDelivered = await _orderService.GetTotalDeliveredAsync(),
                OrdersCancelled = await _orderService.GetTotalCancelledAsync(),
                RecentOrders = await _orderService.GetRecentOrdersAsync(),
                TopCategories = await _categoryService.GetTopCategoriesAsync(),
                TopProducts = await _productService.GetTopProductsAsync()

            };
            return dashboardData;
        }
    }
}