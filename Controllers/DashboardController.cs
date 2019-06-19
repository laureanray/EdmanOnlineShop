using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdmanOnlineShop.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        [HttpGet]
        public async Task<JsonResult> RequestProducts()
        {
            DateTime startDateTime = DateTime.Today;
            DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1);

            var request = await _context.Requests.Where(r => r.RequestDate >= startDateTime && r.RequestDate <= endDateTime).ToListAsync();
            List<CartItem> cartItems = new List<CartItem>();
            if (request != null)        
            {
                foreach (var r in request)
                {
                    var cartItem = await _context.CartItems.FirstOrDefaultAsync(ci => ci.CartItemID == r.CartItemID);
                    cartItems.Add(cartItem);
                }
            }
            
            List<CartItem> ciFiltered = cartItems.OrderBy(ci => ci.Quantity).ToList();
            
            List<ProductsAndQuantity> res = new List<ProductsAndQuantity>();
            if (ciFiltered != null)
            {
                foreach (var i in ciFiltered)
                {
                    var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == i.ProductID);
                    var remaining = new ProductsAndQuantity
                    {
                        Quantity = i.Quantity,
                        ProductName = product.ProductName,
                        ProductID = product.ProductID
                    };
                    
                    
                    res.Add(remaining);
                }
            }

            return Json(res);
        }
        [HttpGet]
        public async Task<JsonResult> Top5LeastNumberOfProductsLeft()
        {
            var inventory = await _context.Inventories.OrderBy(i => i.Quantity).Take(5).ToListAsync();
            List<ProductsAndQuantity> res = new List<ProductsAndQuantity>();
            if (inventory != null)
            {
                foreach (var i in inventory)
                {
                    var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == i.ProductID);
                    var remaining = new ProductsAndQuantity
                    {
                        Quantity = i.Quantity,
                        ProductName = product.ProductName,
                        ProductID = product.ProductID
                    };
                    
                    
                    res.Add(remaining);
                }
            }

            return Json(res);

        }
        
        public DashboardController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize(Roles="Admin, SalesClerk, OperationsManager, Accounting, InternationalCorrespondenceAndSecretary, LogisticsClerk")]
        public async Task<IActionResult> Index()
        {
            DashboardViewModel vm = new DashboardViewModel();
            DateTime startDateTime = DateTime.Today;
            DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1);
            var ordersSoldToday = await 
                _context.Orders.Where(o => o.Status == Status.DELIVERED).Where(o => o.DateDelivered >= startDateTime && o.DateDelivered <= endDateTime)
                    .ToListAsync();

            if (ordersSoldToday != null)
            {               
                int quantitySoldToday = 0;
                decimal totalSalesToday = 0;
                foreach (var order in ordersSoldToday)
                {
                    quantitySoldToday += order.Quantity;
                    totalSalesToday += order.Amount;
                }

                vm.QuantitySoldToday = quantitySoldToday;
                vm.TotalSalesToday = totalSalesToday;
            }

            var totalOrders = await _context.Orders.CountAsync();
            var processedOrders = await _context.Orders.Where(o => o.Status != Status.PENDING).CountAsync();

            if (totalOrders > 0)
            {
                
                float progress = (processedOrders / (float) totalOrders) * 100;
            

                vm.OrderProgress = Convert.ToInt32(Math.Round(progress));

            }
            else
            {
                vm.OrderProgress = 0;
            }
            
            var numOfNewUsers =
                await _context.Users.Where(u => u.DateRegistered >= startDateTime && u.DateRegistered <= endDateTime)
                    .CountAsync();

            vm.NumOfNewRegisterToday = numOfNewUsers;
    
            // for notifications 
            var inventories = await _context.Inventories.ToListAsync();
            vm.Notifications = new List<Notification>();
            if (inventories != null)
            {
                foreach (var i in inventories)
                {
                    if (i.Quantity == 0)
                    {
                        var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == i.ProductID);
                        var notif = new Notification
                        {
                            NotificationHeader = "Item is out of stock",
                            ProductName = product.ProductName,
                            StocksLeft = i.Quantity,
                            ProductImage = product.ProductImage

                        };
                        
                        vm.Notifications.Add(notif);
                    }
                    else if (i.Quantity < i.CriticalLevel)
                    {
                        var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == i.ProductID);
                        var notif = new Notification
                        {
                            NotificationHeader = "Item is in critical level",
                            ProductName = product.ProductName,
                            StocksLeft = i.Quantity,
                            ProductImage = product.ProductImage
                        };
                        
                        vm.Notifications.Add(notif);

                    }
                }
            }


            return View(vm);
        }
        
    }
}