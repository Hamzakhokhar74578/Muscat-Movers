using Microsoft.AspNetCore.Mvc;

namespace MuscatMover.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Aboutt()
        {
            return View();
        }

        public IActionResult Services()

        {
            return View();
        }
        public IActionResult Contact()

        {
            return View();
        }
    }
}
