using System.Diagnostics;
using asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp.Controllers
{
    [NonController]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [NonAction]
        public ActionResult Contact()

        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult User()
        {
            _logger.LogInformation("User");
            return View("User");
        }
    }
}
