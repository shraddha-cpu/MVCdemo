using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;      

namespace MVCdemo.Controllers
{
    public class PersonController : Controller
    {
        // this is by default with httpget
        public IActionResult PersonDetails()
        {
            List<string> list = new List<string>();
            list.Add("Yes");
            list.Add("No");
            ViewData["Option"]=new SelectList(list);
            return View();
        }
        [HttpPost]
        public IActionResult PersonDetails(IFormCollection form,ICollection<string> hobbies)
        {


            return View();
        }
    }
}

