using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
