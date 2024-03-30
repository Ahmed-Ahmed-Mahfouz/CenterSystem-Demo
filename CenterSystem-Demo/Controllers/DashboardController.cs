using Microsoft.AspNetCore.Mvc;

namespace CenterSystem_Demo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }



    }
}
