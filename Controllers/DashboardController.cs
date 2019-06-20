using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace EdmanOnlineShop.Controllers
{
    [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary, Accounting, LogisticsClerk, OperationsManager")]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        [HttpGet]
        public async Task<JsonResult> RequestProducts()
        {
            DateTime startDateTime = DateTime.Today;
            DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1);
            var products = await _context.Products.Where(p => p.IsArchived == false).ToListAsync();
            List<ReturnProductsModel> requests = new List<ReturnProductsModel>();
            if (products != null)
            {
                foreach (var p in products)
                {
                    var prod = new ReturnProductsModel
                    {
                        Quantity = 0,
                        ProductName = p.ProductName,
                        ProductID = p.ProductID
                    };
                    requests.Add(prod);
                }
            }


            foreach (var r in requests)
            {

                var cartItems = await _context.CartItems.Where(req => req.ProductID == r.ProductID && req.IsRequested == true).ToListAsync();

                if (cartItems != null)
                {
                    foreach (var ci in cartItems)
                    {
                        var request = await _context.Requests.FirstOrDefaultAsync(re => re.CartItemID == ci.CartItemID);

                        if (request.RequestDate >= startDateTime && request.RequestDate <= endDateTime)
                        {
                            r.Quantity += ci.Quantity;
                        }

                    }
                }

            }

            requests = requests.OrderByDescending(r => r.Quantity).ToList();
            


            return Json(requests);
        }
        
       
        
        [HttpGet]
        public async Task<JsonResult> ReturnProducts()
        {
            DateTime startDateTime = DateTime.Today;
            DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1);
            var products = await _context.Products.Where(p => p.IsArchived == false).ToListAsync();
            List<ReturnProductsModel> returns = new List<ReturnProductsModel>();
            if (products != null)
            {
                foreach (var p in products)
                {
                    var prod = new ReturnProductsModel
                    {
                        Quantity = 0,
                        ProductName = p.ProductName,
                        ProductID = p.ProductID
                    };
                    returns.Add(prod);
                }
            }


            foreach (var r in returns)
            {
                var returnsFromDb = await _context.Returns.Where(ret => ret.ProductID == r.ProductID && ret.DateReturned >= startDateTime && ret.DateReturned <= endDateTime).ToListAsync();

                if (returnsFromDb != null)
                {
                    foreach (var rfdb in returnsFromDb)
                    {
                        r.Quantity += rfdb.Quantity;
                    }
                }

            }

            returns = returns.OrderByDescending(r => r.Quantity).ToList();
            


            return Json(returns);

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