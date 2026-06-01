using ECommerce.Application.Interface.Service;
using ECommerce.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{

    public HomeController()
    {
    }

    [HttpGet]
    public IActionResult Home()
    {
        return View();
    }
}