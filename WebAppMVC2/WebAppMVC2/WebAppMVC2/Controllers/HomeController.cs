using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC2.Models;

namespace WebAppMVC2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    //[NonAction]
    public ActionResult Contact()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Users()
    {
        _logger.LogInformation("[Users] METHOD: {m}", Request.Method);
        return Content("Users");
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}