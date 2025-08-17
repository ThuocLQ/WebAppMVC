using Microsoft.AspNetCore.Mvc;
using WebAppMVC3.Models;

namespace WebAppMVC3.Controllers;

public class ProductController : Controller
{
    // GET
    [Route("p/{id:int}")]
    public IActionResult Details(int id)
    {
        return View(new Product
        {
            Id = id.ToString(),
            Name = $"Product Name: {id} (int)"
        });
    }
    
    [Route("p/{id}")]
    public IActionResult Details(string id)
    {
        return View(new Product
        {
            Id = id,
            Name = $"Product Name: {id} (string)"
        });
    }
    
}