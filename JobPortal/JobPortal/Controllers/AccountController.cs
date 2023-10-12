using JobPortal.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginView)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UserRegisteration()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EmployerRegisteration()
        {
            return View();
        }
    }
}
