using Microsoft.AspNetCore.Mvc;
using MVCdemo.Models;

namespace MVCdemo.Controllers
{
    public class StudentsssController : Controller
    {
        public IActionResult AddStudentsss()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudentsss(Studentsss stud)
        {
            return View();
        }
    }
}
