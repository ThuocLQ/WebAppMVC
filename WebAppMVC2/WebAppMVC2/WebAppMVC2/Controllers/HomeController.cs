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
    [Route("api/getUsers")]
    public IActionResult Users([FromHeader]  string apikey, [FromServicesAttribute] IUserRepository  userRepository)
    {
        _logger.LogInformation("[Users] apikey: {api}, ", Request.Method);
        ValidateApikey(apikey);
        return Content($"Users: {string.Join(',', userRepository.Users)}");
    }

    private void ValidateApikey(string apikey)
    {
        if (apikey == null)
        {
            throw new ArgumentNullException(nameof(apikey));
        }
    }

    [HttpPost]
    public IActionResult Users([FromHeader]  string apikey, [FromServicesAttribute] IUserRepository userRepository, string user)
    {
        _logger.LogInformation("[Users] METHOD: {m}, apikey: {api}", Request.Method,apikey);
        userRepository.Add(user);
        return Ok();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}