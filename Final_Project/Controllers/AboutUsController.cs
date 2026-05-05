using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class AboutUsController : Controller
    {
        // Handles the About Us page requests
        public IActionResult Index()
        {
            return View();
        }
    }
}
