using Microsoft.AspNetCore.Mvc;

namespace EdmanOnlineShop.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Confirm()
        {
            return View();
        }

    }
}