using Microsoft.AspNetCore.Mvc;

namespace EdmanOnlineShop.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}