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

        public async Task<IActionResult> Restock(int inventoryID)
        {
            var inventory = await _context.Inventories.FirstOrDefaultAsync(iv => iv.InventoryID == inventoryID);
            if (inventory != null)
            {
                RestockInventoryViewModel vm = new RestockInventoryViewModel();

                var product = await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == inventory.ProductID);
                vm.InventoryID = inventoryID;
                vm.Critical = inventory.CriticalLevel;
                vm.Quantity = inventory.Quantity;
                vm.ProductName = product.ProductName;

                return View(vm);

            }

            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> RestockFinal(RestockInventoryViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var inventory = await _context.Inventories.FirstOrDefaultAsync(iv => iv.InventoryID == id);
                    if (inventory != null)
                    {
                        inventory.Quantity = model.Quantity;
                        inventory.CriticalLevel = model.Critical;

                        
                        _context.Entry(inventory).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch (DbUpdateException)
                {
                }
            }

            return NotFound();
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
                            Critical = iv.CriticalLevel,
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