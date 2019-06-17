using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace EdmanOnlineShop.Controllers
{
    public class ReportsController
    {
        public IActionResult ProductsReport()
        {
            var model = new ProductsReprotViewModel();
            model.ProductName = "Test";
            return new ViewAsPdf("ProductsReport", model);
        }
    }
}