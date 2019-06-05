using System.Collections.Generic;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdmanOnlineShop.Controllers
{
    public class InventoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InventoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin, SalesClerk")]
        public async Task<IActionResult> Index()
        {
            List<IndexInventoryViewModel> vm = new List<IndexInventoryViewModel>();

            var inventories = await _context.Inventories.ToListAsync();
            if (inventories != null)
            {
                foreach (var iv in inventories)
                {
                    var product = await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == iv.ProductID);
                    if (product != null)
                    {
                        vm.Add(new IndexInventoryViewModel
                        {
                            Quantity = iv.Quantity,
                            ProductName = product.ProductName,
                            InventoryDate = iv.InventoryDate,
                            Crtitical = iv.CriticalLevel,
                            InventoryID = iv.InventoryID
                        });
                    }
                    else
                    {
                        return NotFound();
                    }
                }

                return View(vm);
            }

            return NotFound();
        }
    }
}