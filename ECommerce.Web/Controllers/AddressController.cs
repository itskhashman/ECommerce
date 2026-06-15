using ECommerce.Application.DTOs.Address;
using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Controllers
{
    public class AddressController : Controller
    {
        private readonly IUserService _userService;

        public AddressController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Create(string returnUrl = null)
        {
            ViewBag.Cities = await _userService.GetAllCitiesAsync();
            ViewBag.ReturnUrl = returnUrl;
            var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
            var userId = int.TryParse(domainUserIdClaim, out int outUserId) ? outUserId : 1;
            var model = new AddressDto { UserId = userId };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddressDto model, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ReturnUrl = returnUrl;
                ViewBag.Cities = await _userService.GetAllCitiesAsync();
                return View(model);
            }

            try
            {
                var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
                var userId = int.TryParse(domainUserIdClaim, out int outUserId) ? outUserId : 1;
                model.UserId = userId;
                await _userService.AddUserAddress(userId, model);
                TempData["SuccessMessage"] = "New address appended successfully.";
                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                return RedirectToAction("MyProfile", "Profile");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                ViewBag.Cities = await _userService.GetAllCitiesAsync();
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int addressId)
        {
            var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
            var userId = int.TryParse(domainUserIdClaim, out int outUserId) ? outUserId : 1;
            var user = await _userService.GetUserWithAddressesAsync(userId);
            var address = user?.Address?.FirstOrDefault(a => a.Id == addressId);
            if (address == null) return NotFound();

            ViewBag.Cities = await _userService.GetAllCitiesAsync();
            return View(address);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(AddressDto model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Cities = await _userService.GetAllCitiesAsync();
                return View(model);
            }

            try
            {
                var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
                var userId = int.TryParse(domainUserIdClaim, out int outUserId) ? outUserId : 1;
                model.UserId = userId;
                await _userService.UpdateUserAddress(userId, model);
                TempData["SuccessMessage"] = "Address updated successfully.";
                return RedirectToAction("MyProfile", "Profile");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                ViewBag.Cities = await _userService.GetAllCitiesAsync();
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int userId , int addressId)
        {
            try
            {
                await _userService.DeleteUserAddress(userId, addressId);
                TempData["SuccessMessage"] = "Address removed.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
            }
            return RedirectToAction("MyProfile", "Profile");
        }
    }
}