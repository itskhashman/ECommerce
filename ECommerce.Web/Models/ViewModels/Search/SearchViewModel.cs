using ECommerce.Application.DTOs.Category;
using ECommerce.Application.DTOs.Products;

namespace ECommerce.Web.Models.Home
{
    public class SearchViewModel
    {
        public string? SearchString { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public bool InStockOnly { get; set; }
        public int? CategoryId { get; set; }

        public IEnumerable<ProductDto> Products { get; set; } = new List<ProductDto>();
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
    }
}