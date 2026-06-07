using ECommerce.Application.DTOs.Category;

namespace ECommerce.Web.Models.ViewModels.Home
{
    public class HomeViewModel
    {
        public List<CategoryDto> MainCategories { get; set; } = new List<CategoryDto>();
        public List<CategoryDto> SubCategories { get; set; } = new List<CategoryDto>();

    }
}
