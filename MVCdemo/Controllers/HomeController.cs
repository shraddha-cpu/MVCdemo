using Microsoft.AspNetCore.Mvc;
using MVCdemo.Models;
using System.Diagnostics;

namespace MVCdemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"]="this is viewdata example";
            ViewData["name"]="Mayuri";
            ViewData["per"]=80.80;
            List<string> colors = new List<string>()
            {
                "Red" , "Green" , "Blue" , "Black" , "White" , "Pink"
            };
            ViewData["colors"] = colors;

            ViewBag.UserName="Nikita";
            ViewBag.Email = "Nikita2@gmail.com";
            ViewBag.Colors=colors;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}