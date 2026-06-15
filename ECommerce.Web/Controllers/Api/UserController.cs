using ECommerce.Application.DTOs.User;
using ECommerce.Application.Interface.Service;
using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IIdentityService _identityService;

        public UserController(IUserService userService, IIdentityService identityService)
        {
            _userService = userService;
            _identityService = identityService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddUser([FromBody] CreateUserDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            string identityRoleName = dto.RoleId switch
            {
                1 => "Admin",
                2 => "Customer",
                _ => "Customer"
            };

            var success = await _identityService.RegisterAsync(
                dto.UserName,
                dto.Email,
                dto.Password,
                dto.FirstNameAr,
                dto.MiddleNameAr,
                dto.LastNameAr,
                dto.FirstNameEn,
                dto.MiddleNameEn,
                dto.LastNameEn,
                dto.Phone,
                dto.RoleId,
                identityRoleName
            );

            if (!success)
                return BadRequest(new { message = "Failed to register system account structural constraints." });

            return Ok(new { success = true, message = "User account created cleanly across Identity and Domain layers!" });
        }

        [HttpPost("Edit/{userId:int}")]
        public async Task<IActionResult> EditUser([FromRoute] int userId, [FromBody] UpdateUserDto model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (model == null || model.Id == 0 || model.Id != userId)
            {
                return BadRequest(new { success = false, message = "Invalid user target parameters or routing mismatch." });
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