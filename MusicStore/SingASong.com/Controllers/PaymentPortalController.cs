using Microsoft.AspNetCore.Mvc;

namespace SingASong.com.Controllers
{
    public class PaymentPortalController : Controller
    {
        public IActionResult PaymentMethod()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
    }
}
