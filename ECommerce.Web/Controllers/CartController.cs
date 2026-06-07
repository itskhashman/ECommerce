
using ECommerce.Application.Interfaces;
using ECommerce.Application.Interfaces.services;
using ECommerce.Web.Models.Home;
using Microsoft.AspNetCore.Mvc;

public class CartController : Controller
{
    private readonly IHomeService _homeService;
    private readonly ICategoryService _categoryService;

    public CartController(IHomeService homeService, ICategoryService categoryService)
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
    [HttpGet]
    public async Task<IActionResult> Search(SearchViewModel viewModel)
    {
        var results = await _homeService.GetSearchedProductAsync(
            viewModel.SearchString,
            viewModel.CategoryId,
            viewModel.MinPrice,
            viewModel.MaxPrice,
            viewModel.InStockOnly
        );

        viewModel.Products = results;
        viewModel.Categories = await _categoryService.GetAllMainCategoriesAsync();

        return View(viewModel);
    }
}