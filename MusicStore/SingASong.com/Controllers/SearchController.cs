using Microsoft.AspNetCore.Mvc;

namespace SingASong.com.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Search()
        {
            return View();
        }
    }
}
