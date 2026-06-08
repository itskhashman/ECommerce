using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("AddToCart/{userId}")]
        public async Task<IActionResult> AddToCart([FromRoute] int userId, [FromQuery] int skuId, [FromQuery] int quantity)
        {
            var cart = await _cartService.GetCartByUserIdAsync(userId);
            if (cart == null)
            {
                cart = await _cartService.CreateCartAsync(userId);
            }

            try
            {
                var updatedCart = await _cartService.AddItemToCartAsync(userId, cart.Id, skuId, quantity);

                return Ok(new
                {
                    success = true,
                    message = "Successfully added items to the cart!",
                    data = updatedCart
                });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new
                {
                    success = false,
                    message = ex.Message
                });
            }
        }
        [HttpPost("UpdateQuantity/{userId}/{skuId}")]
        public async Task<IActionResult> UpdateQuantity([FromRoute] int userId, [FromRoute] int skuId, [FromQuery] int quantity)
        {
            try
            {
                var cart = await _cartService.GetCartByUserIdAsync(userId);
                if (cart == null) return NotFound(new { success = false, message = "Cart not found." });

                var updatedCart = await _cartService.UpdateCartItemQuantityAsync(cart.Id, skuId, quantity);

                return Ok(new
                {
                    success = true,
                    message = "Quantity updated successfully!",
                    data = updatedCart
                });
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        [HttpDelete("RemoveItem/{userId}/{skuId}")]
        public async Task<IActionResult> RemoveItem([FromRoute] int userId, [FromRoute] int skuId)
        {
            var cart = await _cartService.GetCartByUserIdAsync(userId);
            if (cart == null) return NotFound(new { success = false, message = "Cart not found." });

            await _cartService.RemoveItemFromCartAsync(cart.Id, skuId);

            return Ok(new
            {
                success = true,
                message = "Item removed from cart successfully!"
            });
        }
    }
}