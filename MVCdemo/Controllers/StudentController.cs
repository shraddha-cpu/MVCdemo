using Microsoft.AspNetCore.Mvc;
using MVCdemo.Models;

namespace MVCdemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentList()
        {

            List <Student> stud = new List<Student>()
                {
                
                    new Student{Rollno=1,Name="neha",Faculty="computer science",Sub1=78,Sub2=88},
                      new Student{Rollno=2,Name="priti",Faculty="comp application",Sub1=82,Sub2=82},
                    new Student{Rollno=3,Name="neha",Faculty="mechanical",Sub1=78,Sub2=88},
                   new Student{Rollno=4,Name="priti",Faculty="accounting",Sub1=82,Sub2=82},
                    new Student{Rollno=5,Name="neha",Faculty="ITI",Sub1=78,Sub2=88},
            };
            ViewData["studentlist"] = stud;
            //or
            ViewBag.studentList = stud;

            return View();
        }
    }
}
