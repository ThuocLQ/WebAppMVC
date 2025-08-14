using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers;

public class MathController : Controller
{
    public IActionResult Sum(int a, int b)
    {
        return Content((a+b).ToString());
    }
    
}