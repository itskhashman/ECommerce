
using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

public class WishlistController : Controller
{
    private readonly IWishlistService _wishlistService;

    public WishlistController(IWishlistService wishlistService)
    {
        _wishlistService = wishlistService;
    }

    [HttpGet]
    public async Task<IActionResult> Wishlist()
    {
        var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;

        int userId = int.TryParse(domainUserIdClaim, out int parsedUserId) ? parsedUserId : 1;
        
        var wishlist = await _wishlistService.GetWishlistByUserIdAsync(userId);
        return View(wishlist);
    }
}