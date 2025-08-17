using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC3.Controllers;

public class CollectionController : Controller
{
    // GET
    public IActionResult Index(string id)
    {
        return View(model:id);
    }
}