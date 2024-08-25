using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;
public class HaKieuAnhController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}