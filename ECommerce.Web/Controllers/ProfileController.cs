using ECommerce.Application.DTOs.User;
using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly IUserService _userService;

        public ProfileController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> MyProfile()
        {
            var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
            var userId = int.TryParse(domainUserIdClaim, out int outUserId) ? outUserId : 1;
            var model = await _userService.GetUserWithAddressesAsync(userId);

            ViewBag.Cities = await _userService.GetAllCitiesAsync();
            ViewBag.Countries = await _userService.GetAllCountriesAsync();

            return View(model);
        }
        [HttpGet]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Edit()
        {
            var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
            var userId = int.TryParse(domainUserIdClaim, out int outUserId) ? outUserId : 1;
            var user = await _userService.GetUserWithAddressesAsync(userId);
            if (user == null) return NotFound();

            var model = new UpdateUserDto
            {
                Id = user.Id,
                FirstNameAr = user.FirstNameAr,
                MiddleNameAr = user.MiddleNameAr,
                LastNameAr = user.LastNameAr,
                FirstNameEn = user.FirstNameEn,
                MiddleNameEn = user.MiddleNameEn,
                LastNameEn = user.LastNameEn,
                Email = user.Email,
                Phone = user.Phone,
                IsActive = user.IsActive,
                IsEmailVerified = user.IsEmailVerified,
                RoleId = user?.UserRoles?.FirstOrDefault()?.Id
            };

            return View(model);
        }
        [HttpPost]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Edit(UpdateUserDto model)
        {
            var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
            var userId = int.TryParse(domainUserIdClaim, out int outUserId) ? outUserId : 1;
            model.Id = userId;

            var originalUser = await _userService.GetUserWithAddressesAsync(userId);
            if (originalUser == null) return NotFound();

            model.Email = originalUser.Email;
            model.IsActive = originalUser.IsActive;
            model.IsEmailVerified = originalUser.IsEmailVerified;
            model.RoleId = originalUser?.UserRoles?.FirstOrDefault()?.Id;

            ModelState.Clear();

            if (!TryValidateModel(model))
            {
                return View(model);
            }

            try
            {
                await _userService.UpdateUserInfo(model);
                return RedirectToAction("MyProfile");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Failed to process profile changes: {ex.Message}");
                return View(model);
            }
        }
    }
}