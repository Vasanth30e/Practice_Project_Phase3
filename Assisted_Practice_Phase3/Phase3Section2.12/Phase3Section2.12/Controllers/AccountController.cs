using Microsoft.AspNetCore.Mvc;

namespace Phase3Section2._12.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
