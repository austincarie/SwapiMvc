using Microsoft.AspNetCore.Mvc;

namespace SwapiMvc.WebMvc.Controllers;

public class PeopleController : Controller
{
    public async Task<IActionResult> Index()
    {
        return View();
    }
}