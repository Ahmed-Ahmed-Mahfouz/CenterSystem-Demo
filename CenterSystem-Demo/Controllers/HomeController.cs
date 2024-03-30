using CenterSystem_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CenterSystem_Demo.Controllers
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
            return View("index");
        }


        public IActionResult Add()
        {
            return View("add");
        }


        public IActionResult login()
        {
            return View("Login");
        }

        public IActionResult register()
        {
            return View("Register");
        }

        public IActionResult Financial()
        {
            return View("index");
        }
        public IActionResult Privacy()
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
