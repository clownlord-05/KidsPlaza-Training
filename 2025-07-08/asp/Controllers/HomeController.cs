using asp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace asp.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository { get; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(IRepository repository,ILogger<HomeController> logger)
        {
            this.Repository = repository;
            _logger = logger;

            
        }

        public IActionResult Index()
        {
            return View(new HelloModel() { Name = "asp.net"});
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult NewActionMethod()
        {
            return Content("Hi from NewActionMethod!" + Repository.GetById("MYID"));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
