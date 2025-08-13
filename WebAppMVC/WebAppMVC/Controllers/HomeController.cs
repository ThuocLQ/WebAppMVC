using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepository repository;
    public HomeController(IRepository repository, ILogger<HomeController> logger)
    {
        this.repository = repository;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(new HelloModel() { Name = "Tu tiên"});
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult HeheActionMethod()
    {
        return Content("Tu tiên vượt cấp " + repository.GetById("ID123"));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}