
using Microsoft.AspNetCore.Mvc;

public class SearchController : Controller
{

    public SearchController()
    {
    }

    [HttpGet]
    public IActionResult Search(string query)
    {
        return View(query);
    }
}