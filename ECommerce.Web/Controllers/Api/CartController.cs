
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")] 
    public class CartController : ControllerBase
    {
        [HttpPost("AddToCart")] 
        public IActionResult AddToCart([FromQuery] int skuId , [FromQuery] int quantity)
        {
            if (skuId <= 0)
            {
                return BadRequest(new { success = false, message = "Invalid SKU ID." });
            }


            return Ok(new
            {
                success = true,
                message = $"Successfully added {quantity} units of SKU {skuId} to the cart!"
            });
        }
    }
}