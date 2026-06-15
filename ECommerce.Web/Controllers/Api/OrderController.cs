using ECommerce.Application.DTOs.Address;
using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

      
        [HttpPost("Edit/{userId:int}")]
        public async Task<IActionResult> EditOrder([FromRoute] int userId, [FromBody] int orderStatusId)
        {
            try
            {
                await _orderService.UpdateOrderAsync(userId ,orderStatusId);

                return Ok(new { success = true, message = "Address updated successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }
        [HttpDelete("Delete/{orderId:int}")]
        public async Task<IActionResult> DeleteOrder([FromRoute] int orderId)
        {
            try
            {
                await _orderService.DeleteOrderAsync(orderId);
                return Ok(new { success = true, message = "Order deleted successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }
    }
}