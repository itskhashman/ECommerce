using ECommerce.Application.DTOs.Category;
using ECommerce.Application.DTOs.Products;

namespace ECommerce.Application.DTOs.Home
{
    public class HomeDto : BaseDto
    {
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
        public IEnumerable<ProductDto> NewestProducts { get; set; } = new List<ProductDto>();
    }
}