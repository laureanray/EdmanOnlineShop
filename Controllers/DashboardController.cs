using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EdmanOnlineShop.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize(Roles="Admin, SalesClerk, OperationsManager, Accounting, InternationalCorrespondenceAndSecretary, LogisticsClerk")]
        public IActionResult Index()
        {
            return View();
        }
        
    }
}