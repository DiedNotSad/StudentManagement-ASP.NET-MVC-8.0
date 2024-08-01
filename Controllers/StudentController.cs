using Microsoft.AspNetCore.Mvc;
using Moncc.Models;

namespace Moncc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Account a)
        {
            return View();
        }
    }
}
