using Microsoft.AspNetCore.Mvc;
using Moncc.Data;
using Moncc.Models;

namespace Moncc.Controllers
{
    public class AccessController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult Login(Account account)
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                var a= db.Accounts.Where(x=>x.Username.Equals(account.Username) &&x.Password.Equals(account.Password)).FirstOrDefault();
                if (a != null)
                {
                    HttpContext.Session.SetString("Username",a.Username.ToString());
                    return RedirectToAction("Index", "Home");
                }

            }
            return View();
        }
    }
}
