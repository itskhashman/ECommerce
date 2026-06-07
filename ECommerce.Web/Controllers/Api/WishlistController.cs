
using ECommerce.Application.DTOs.Wishlist;
using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class WishlistController : ControllerBase
    {
        private readonly IWishlistService _wishlistService;

        public WishlistController(IWishlistService wishlistService)
        {
            _wishlistService = wishlistService;
        }

        [HttpPost("AddToWishlist")]
        public async Task<IActionResult> AddToWishlist([FromQuery] int productId, [FromQuery] int userId)
        {
            var wishlist = await _wishlistService.GetWishlistByUserIdAsync(userId);

            if (wishlist == null)
            {
                wishlist = await _wishlistService.CreateWishlistAsync(userId);
            }

            var itemDto = new WishlistItemDto { ProductId = productId, WishlistId = wishlist.Id };
            await _wishlistService.AddItemToWishlistAsync(wishlist.Id, itemDto);

            return Ok(new
            {
                success = true,
                message = $"Successfully product added to your wishlist!"
            });
        }

        [HttpPost("RemoveFromWishlist")]
        public async Task<IActionResult> RemoveFromWishlist([FromQuery] int productId, [FromQuery] int userId)
        {
            await _wishlistService.RemoveItemFromWishlistAsync(userId, productId);

            return Ok(new
            {
                success = true,
                message = $"Successfully removed product from your wishlist!"
            });

        }
    }
}