using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Rotativa.AspNetCore;
using Rotativa.AspNetCore.Options;

namespace EdmanOnlineShop.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> SalesReport(ReportsViewModel model)
        {
            
            DateTime startDateTime = model.FromDate;
            DateTime endDateTime = model.ToDate.AddDays(1).AddTicks(-1);
            
            var sales = await
                _context.Orders.Where(o =>
                    o.Status == Status.DELIVERED &&
                    (o.DateOrdered >= startDateTime && o.DateOrdered <= endDateTime)).ToListAsync();

            var vm = new SalesReportViewModel();
            vm.Sales = new List<SalesDetails>();
            vm.FromDate = model.FromDate;
            vm.ToDate = model.ToDate;

            if (sales != null)
            {
                foreach (var s in sales)
                {

                    var product = await _context.Products.FirstOrDefaultAsync (p => p.ProductID == s.ProductID);
                    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == s.UserID);
                    var details = new SalesDetails
                    {
                        OrderID = s.OrderID,
                        Quantity = s.Quantity,
                        PaymentMethod = s.PaymentMethod,
                        Status = s.Status,
                        TotalPrice = s.Amount,
                        Price = product.Price,
                        CustomerName = user.FirstName + " " + user.LastName,
                        DateOrdered = s.DateOrdered,
                        ProductName = product.ProductName
                    };
                    
                    vm.Sales.Add(details);
                }
                
                return new ViewAsPdf("SalesReport", vm)
                {
                    PageOrientation = Orientation.Landscape,
                    FileName = "SalesReport.pdf"
                };


            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> GenerateReport(ReportsViewModel model)
        {
            if (ModelState.IsValid)
            {
                switch (model.Report)
                {
                    case Report.INVENTORY:
                        return RedirectToAction(nameof(InventoryReport));
                    case Report.SALES:
                        return await SalesReport(model);
                    case Report.REQUEST:
                        return await RequestReport(model);
                    default:
                        return NotFound();
                }
            }

            return NotFound();
        }

        public async Task<IActionResult> RequestReport(ReportsViewModel model)
        {
            
            DateTime startDateTime = model.FromDate;
            DateTime endDateTime = model.ToDate.AddDays(1).AddTicks(-1);
            
            var requests = await
                _context.Requests.Where(r => r.RequestDate >= startDateTime && r.RequestDate <= endDateTime).ToListAsync();

            var vm = new RequestReportViewModel();
            vm.Requests = new List<RequestDetails>();
            vm.FromDate = model.FromDate;
            vm.ToDate = model.ToDate;
            
            
            if (requests != null)
            {
                foreach (var r in requests)
                {
                    var cartItem = await _context.CartItems.FirstOrDefaultAsync(ci => ci.CartItemID == r.CartItemID);
                    var product = await _context.Products.FirstOrDefaultAsync (p => p.ProductID == cartItem.ProductID);
                    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == r.UserID);
                    var details = new RequestDetails
                    {
                        Price = cartItem.Quantity * product.Price,
                        Quantity = cartItem.Quantity,
                        User = user,
                        DateRequested = r.RequestDate,
                        ProductName = product.ProductName,
                        RequestStatus = r.RequestStatus,
                    };
                    
                    vm.Requests.Add(details);
                }
                
                return new ViewAsPdf("RequestReport", vm)
                {
                    PageOrientation = Orientation.Landscape,
                    FileName = "RequestReport.pdf"
                };


            }

            return NotFound();
             
        }
        
        public async Task<IActionResult> InventoryReport()
        {
            var inventories = await _context.Inventories.ToListAsync();
            var model = new InventoryReportViewModel();
            model.Inventories = new List<InventoryDetails>();
            
            if (inventories != null)
            {
                foreach (var i in inventories)
                {
                    var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == i.ProductID);

                    var category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryID == product.CategoryID);
                    model.Inventories.Add(new InventoryDetails
                    {
                        Category = category,
                        Product = product,
                        Inventory = i
                    });
                }


                return new ViewAsPdf(model)
                {
                    PageOrientation = Orientation.Landscape
                };
            }

            return NotFound();
        }
        

        public IActionResult Index()
        {
            return View();
        }
    }
}