using Microsoft.AspNetCore.Mvc;

namespace WatchWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
