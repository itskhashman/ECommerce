using ECommerce.Application.DTOs.Category;

namespace ECommerce.Application.DTOs.Home
{
    public class HomeDto : BaseDto
    {
        public IEnumerable<CategoryDto> Categories { get; set; } = new List<CategoryDto>();
    }
}