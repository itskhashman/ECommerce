
using ECommerce.Application.Interfaces;
using ECommerce.Application.Interfaces.services;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly IHomeService _homeService;
    private readonly ICategoryService _categoryService;

    public HomeController(IHomeService homeService, ICategoryService categoryService)
    {
        _homeService = homeService;
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> Home()
    {
        var model = await _homeService.GetHomeDataAsync();

        return View(model);
    }
}