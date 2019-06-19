using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdmanOnlineShop.Controllers
{
    public class DeliveriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DeliveriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _context.Orders.Where(o => o.Status == Status.TO_RECEIVE).ToListAsync();
            IndexOrderViewModel vm = new IndexOrderViewModel();
            vm.Orders = new List<OrderDetails>();

            if (orders != null)
            {
                foreach (var order in orders)
                {
                    var product = await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == order.ProductID);
                    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == order.UserID);
                    vm.Orders.Add(new OrderDetails
                    {
                        Amount = order.Amount,
                        Quantity = order.Quantity,
                        Status = order.Status,
                        DatePlaced = order.DateOrdered,
                        DeliverDate = order.DateToDeliver,
                        ProductImage = product.ProductImage,
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        FirstName = user.FirstName,
                        OrderID = order.OrderID,
                        LastName = user.LastName,
                        Price = product.Price
                    });
                }

                return View(vm);
            }

            return View();
        }
        
        public async Task<IActionResult> Archived()
        {
            var orders = await _context.Orders.Where(o => o.Status == Status.DELIVERED).ToListAsync();
            IndexOrderViewModel vm = new IndexOrderViewModel();
            vm.Orders = new List<OrderDetails>();

            if (orders != null)
            {
                foreach (var order in orders)
                {
                    var product = await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == order.ProductID);
                    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == order.UserID);
                    vm.Orders.Add(new OrderDetails
                    {
                        Amount = order.Amount,
                        Quantity = order.Quantity,
                        Status = order.Status,
                        DatePlaced = order.DateOrdered,
                        DeliverDate = order.DateToDeliver,
                        ProductImage = product.ProductImage,
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        FirstName = user.FirstName,
                        OrderID = order.OrderID,
                        LastName = user.LastName,
                        Price = product.Price
                    });
                }

                return View(vm);
            }

            return View();
        }


        public async Task<IActionResult> Delivered(int orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == orderId);

            if (order != null)
            {
                order.Status = Status.DELIVERED;
                order.DateDelivered = DateTime.Now;
                _context.Entry(order).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> Cancelled(int orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == orderId);

            if (order != null)
            {
                order.Status = Status.CANCELLED;
                _context.Entry(order).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}