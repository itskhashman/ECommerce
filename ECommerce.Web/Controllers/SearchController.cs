
using ECommerce.Application.DTOs.Wishlist;
using ECommerce.Application.Interfaces;
using ECommerce.Application.Interfaces.services;
using ECommerce.Web.Models.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
public class SearchController : Controller
{
    private readonly ISearchService _searchService;
    private readonly ICategoryService _categoryService;
    private readonly IProductService _productService;
    private readonly IWishlistService _wishlistService;

    public SearchController(ISearchService searchService, ICategoryService categoryService, IProductService productService, IWishlistService wishlistService)
    {
        _categoryService = categoryService;
        _searchService = searchService;
        _productService = productService;
        _wishlistService = wishlistService;
    }

    [HttpGet]
    public async Task<IActionResult> Search(SearchViewModel viewModel)
    {
        var results = await _searchService.GetSearchedProductAsync(
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
    [HttpGet]
    [Authorize(Roles = "Customer")]
    public async Task<IActionResult> Details(int productId)
    {
        var product = await _productService.GetByIdAsync(productId);
        var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
        ViewBag.UserId = int.TryParse(domainUserIdClaim, out int userId) ? userId : 1;
        WishlistDto? wishlist = await _wishlistService.GetWishlistByUserIdAsync(ViewBag.UserId);
        ViewBag.IsProductWishlisted = wishlist != null ? wishlist?.WishlistItems?
            .Any(item => item != null && item.ProductId == productId) ?? false : false;
        return View(product);
    }

}