using Microsoft.AspNetCore.Mvc;
using MVCdemo.Models;
using System.Collections.Generic;
namespace MVCdemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            List<Employee> employees = new List<Employee>()
                {
                new Employee{Id=1,Name="nikita",Designation="Manager",Salary=56000},
                 new Employee{Id=2,Name="mansi",Designation="Development",Salary=46000},
                  new Employee{Id=3,Name="mayuri",Designation="Development",Salary=46000},
                   new Employee{Id=4,Name="priti",Designation="Tester",Salary=36000},
                    new Employee{Id=5,Name="neha",Designation="Tester",Salary=26000},
            };
            ViewData["emplist"] = employees;
            //or
            ViewBag.EmpList = employees;
            return View();
        }
    }
}
