using ECommerce.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

public class UsersController : Controller
{
    private readonly IUserService _userService;
    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet("Profile")]
    public async Task<IActionResult> Profile()
    {
        var domainUserIdClaim = User.FindFirst("DomainUserId")?.Value;
        var userId = int.TryParse(domainUserIdClaim, out int outUserId) ? outUserId : 1;
        var model = await _userService.GetUserWithAddressesAsync(userId);

        ViewBag.Cities = await _userService.GetAllCitiesAsync(); 
        ViewBag.Countries = await _userService.GetAllCountriesAsync(); 

        return View(model);
    }

}