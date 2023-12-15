using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SwapiMvc.Models;

namespace SwapiMvc.WebMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Random rand = new Random();
        string[] names = {"Sam", "Sy", "Ben", "Deionta", "Hakima", "Robert", "Austin"};

        string name = names[rand.Next(0, names.Length)];
        return View(model: name);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
