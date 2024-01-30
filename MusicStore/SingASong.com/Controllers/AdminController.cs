using Microsoft.AspNetCore.Mvc;

namespace SingASong.com.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminList()
        {
            return View();
        }
        public IActionResult AdminReport()
        {
            return View();
        }

    }
}