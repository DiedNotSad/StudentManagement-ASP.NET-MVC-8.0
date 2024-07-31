using Microsoft.AspNetCore.Mvc;

namespace Moncc.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
