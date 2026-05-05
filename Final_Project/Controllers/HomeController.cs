using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Final_Project.Controllers
{
    public class HomeController : Controller
    {
         // Loads the homepage of the application
        public IActionResult Index()
        {
            return View();
        }
        // Loads the Privacy page (static informational page)
        public IActionResult Privacy()
        {
            return View();
        }
        // Handles application errors and prevents caching of error pages
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Passes request details to the Error view for debugging purposes
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
