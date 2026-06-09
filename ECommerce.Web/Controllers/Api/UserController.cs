using ECommerce.Application.DTOs.User;
using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Edit/{userId:int}")]
        public async Task<IActionResult> EditUser([FromRoute] int userId, [FromBody] UpdateUserDto model)
        {
            if (model == null || model.Id == 0)
            {
                return BadRequest(new { success = false, message = "Invalid user target parameters." });
            }

            try
            {
                await _userService.UpdateUserInfo(model);

                return Ok(new { success = true, message = "User information updated successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }
    }
}