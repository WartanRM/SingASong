using Microsoft.AspNetCore.Mvc;

namespace SingASong.com.Controllers
{
    public class CartController : Controller
    {
        public IActionResult ShoppingCart()
        {
            return View();
        }
    }
}
