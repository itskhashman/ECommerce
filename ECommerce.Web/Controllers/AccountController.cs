using ECommerce.Application.Interface.Service;
using ECommerce.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    private readonly IIdentityService _identityService;

    public AccountController(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (!ModelState.IsValid) return View(model);

        var result = await _identityService.RegisterAsync(
            model.Email, model.Password, model.FirstNameAr, model.MiddleNameAr, model.LastNameAr,
            model.FirstNameEn, model.MiddleNameEn, model.LastNameEn, model.Phone);

        if (result) return RedirectToAction("Index", "Home");

        ModelState.AddModelError("Register Failed", "Registration failed.");
        return View(model);
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(string email, string password, bool rememberMe)
    {
        var result = await _identityService.LoginAsync(email, password, rememberMe);
        if (result) return RedirectToAction("Index", "Home");

        ModelState.AddModelError("Login Failed", "Invalid login attempt.");
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await _identityService.LogoutAsync();
        return RedirectToAction("Index", "Home");
    }
}