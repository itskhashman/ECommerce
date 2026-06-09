using ECommerce.Application.DTOs.Address;
using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressesController : ControllerBase
    {
        private readonly IUserService _userService;

        public AddressesController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Add/{userId:int}")]
        public async Task<IActionResult> AddAddress([FromRoute] int userId, [FromBody] AddressDto model)
        {
            if (model == null)
            {
                return BadRequest(new { success = false, message = "Invalid address data payload." });
            }

            try
            {
                model.UserId = userId;
                var createdAddress = await _userService.AddUserAddress(userId, model);

                return Ok(new { success = true, message = "Address saved successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

        [HttpPost("Edit/{userId:int}")]
        public async Task<IActionResult> EditAddress([FromRoute] int userId, [FromBody] AddressDto model)
        {
            if (model == null || model.Id == 0)
            {
                return BadRequest(new { success = false, message = "Invalid address target parameters." });
            }

            try
            {
                model.UserId = userId;
                await _userService.UpdateUserAddress(userId, model);

                return Ok(new { success = true, message = "Address updated successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }
        [HttpDelete("Delete/{userId:int}/{addressId:int}")]
        public async Task<IActionResult> DeleteAddress([FromRoute] int userId, [FromRoute] int addressId)
        {
            try
            {
                await _userService.DeleteUserAddress(userId, addressId);
                return Ok(new { success = true, message = "Address deleted successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }
    }
}