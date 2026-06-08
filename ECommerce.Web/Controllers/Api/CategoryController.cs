
using ECommerce.Application.Interfaces.services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")] 
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetSubCategories")]
        public async Task<IActionResult> GetSubCategories([FromQuery] int mainCategoryId)
        {
            var subCategories = await _categoryService.GetSubCategoriesByMainCategoryIdAsync(mainCategoryId);

            return new JsonResult(subCategories.Select(c => new { id = c.Id, name = c.NameEn }));
        }
    }
}