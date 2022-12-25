using Microsoft.AspNetCore.Mvc;

namespace Jarra.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
