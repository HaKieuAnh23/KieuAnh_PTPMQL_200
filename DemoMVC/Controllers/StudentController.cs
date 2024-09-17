using DemoMVC.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student std)
        {
            string output = "xin chao" + std.StudentID + "-" +std.FullName;
        return View();

        }
    }
}
    