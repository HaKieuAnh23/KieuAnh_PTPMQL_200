using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;
public class StudentController : Controller 
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Index(Student std)
    {
        ViewBag.message = std.StudentID + "-" + std.FullName; 
        return View();
    }
}