
using ECommerce.Application.Interfaces;
using ECommerce.Application.Interfaces.services;
using Microsoft.AspNetCore.Authorization;
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

    public async Task<IActionResult> Home()
    {
        var homeData = await _homeService.GetHomeDataAsync();

        return View(homeData);
    }
    [HttpGet("Dashboard")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Dashboard()
    {
        var dashboardData = await _homeService.GetDashboardDateAsync();
        return View(dashboardData);
    }
}