
using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public class CartController : Controller
{
    private readonly ICartService _cartService;

    public CartController(ICartService cartService)
    {
        _cartService = cartService;
    }

    [HttpGet("Cart")]
    [Authorize(Roles = "Customer")]
    public async Task<IActionResult> Cart()
    {
        var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
        int userId = int.TryParse(domainUserIdClaim, out int parsedUserId) ? parsedUserId : 1;

        var model = await _cartService.GetCartByUserIdAsync(userId);

        return View(model);
    }
}