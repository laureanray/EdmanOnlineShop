using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdmanOnlineShop.Controllers
{
    public class ReturnController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReturnController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ReturnConfirm(int id)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == id);
            var vm = new ReturnConfirmViewModel();
            if (order != null)
            {
                var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == order.ProductID);
                vm.Order = order;
                vm.OrderID = order.OrderID;
                vm.Product = product;
                return View(vm);
            }

            return NotFound();



        }

    }
}