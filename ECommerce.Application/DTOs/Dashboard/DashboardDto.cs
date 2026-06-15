
using ECommerce.Application.DTOs.Category;
using ECommerce.Application.DTOs.Order;
using ECommerce.Application.DTOs.Products;

namespace ECommerce.Application.DTOs.Dashboard
{
    public class DashboardDto
    {
        public int? TotalUsers { get; set; }
        public int? TotalProducts { get; set; }
        public int? TotalCategories { get; set; }
        public decimal? TotalSales { get; set; }
        public int? TotalOrders { get; set; }
        public Dictionary<DateTime, int>? OrdersLastWeek { get; set; }
        public int? OrdersPending { get; set; }
        public int? OrdersConfirmed { get; set; }
        public int? OrdersShipped { get; set; }
        public int? OrdersDelivered { get; set; }
        public int? OrdersCancelled { get; set; }
        public IEnumerable<OrderDto?> RecentOrders { get; set; }
        public Dictionary<int,ProductDto> TopProducts { get; set; }
        public Dictionary<int, CategoryDto> TopCategories { get; set; }

    }
}
