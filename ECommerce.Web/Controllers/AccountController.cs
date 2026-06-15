using ECommerce.Application.Interface.Service;
using ECommerce.Web.Models.ViewModels.Account;
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

        var result = await _identityService.RegisterAsync(model.Username
            , model.Email, model.Password, model.FirstNameAr, model.MiddleNameAr, model.LastNameAr,
            model.FirstNameEn, model.MiddleNameEn, model.LastNameEn, model.Phone,2,"Customer");

        if (result) return RedirectToAction("Home", "Home");

        ModelState.AddModelError("Register Failed", "Registration failed.");
        return View(model);
    }

    [HttpGet]
    public IActionResult Login(string returnUrl = null)
    {
        ViewBag.ReturnUrl = returnUrl;
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(model);
        }

        var result = await _identityService.LoginAsync(model.Email, model.Password, model.RememberMe);

        if (result)
        {
            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Home", "Home");
        }

        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        ViewBag.ReturnUrl = returnUrl;
        return View(model);
    }
    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await _identityService.LogoutAsync();
        return RedirectToAction("Login");
    }
    [HttpGet]
    public IActionResult AccessDenied()
    {
        if (User.Identity != null && User.Identity.IsAuthenticated)
        {
            return RedirectToAction("Home", "Home");
        }

        return RedirectToAction("Login");
    }
}