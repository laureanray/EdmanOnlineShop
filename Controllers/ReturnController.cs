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
using Microsoft.EntityFrameworkCore.Internal;

namespace EdmanOnlineShop.Controllers
{
    public class ReturnController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReturnController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize(Roles = "Customer")]

        public async Task<IActionResult> Index()
        {
                        
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = user.Id;
            var vm = new IndexReturnsViewModel();
            vm.Returns = new List<ReturnDetails>();
            var returns = await _context.Returns.Where(r => r.UserID == userId).ToListAsync();

            if (returns != null)
            {
                foreach (var re in returns)
                {
                    var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == re.ProductID);
                    var rd = new ReturnDetails
                    {
                        Status = re.Status,
                        DateReturned = re.DateReturned,
                        ProductImage = product.ProductImage,
                        ProductName = product.ProductName,
                        ReturnQuantity = re.Quantity
                    };
                    
                    vm.Returns.Add(rd);
                }

                return View(vm);
            }

            return NotFound();
        }

        [Authorize(Roles = "Customer")]

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
        
        [Authorize(Roles = "Customer")]

        [HttpPost]
        public async Task<IActionResult> Return(ReturnConfirmViewModel model)
        {
//            var ms = model.QuantityToReturn;
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == model.OrderID);
            
            
            if (order != null && order.Quantity < model.QuantityToReturn || model.QuantityToReturn <= 0)
            {
                return Unauthorized();
            }
            
            
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = user.Id;


            Return return_ = new Return();

            return_.Quantity = model.QuantityToReturn;
            return_.Status = ReturnStatus.PENDING;
            return_.DateReturned = DateTime.Now;
            return_.UserID = userId;
            return_.ProductID = model.ProductID;
            return_.OrderID = model.OrderID;

            _context.Returns.Add(return_);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary, LogisticsClerk")]

        public async Task<IActionResult> Approve(int id)
        {
            var return_ = await _context.Returns.FirstOrDefaultAsync(r => r.ReturnID == id);

            if (return_ == null)
            {
                return NotFound();
            }

            return_.Status = ReturnStatus.RETURNED;

            _context.Entry(return_).State = EntityState.Modified;



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ReturnsTable));
        }
        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary, LogisticsClerk")]

        public async Task<IActionResult> Reject(int id)
        {
            var return_ = await _context.Returns.FirstOrDefaultAsync(r => r.ReturnID == id);

            if (return_ == null)
            {
                return NotFound();
            }

            return_.Status = ReturnStatus.REJECTED;

            _context.Entry(return_).State = EntityState.Modified;



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ReturnsTable));
        }

        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary, LogisticsClerk")]

        public async Task<IActionResult> ReturnsTable()
        {
            var returns = await _context.Returns.Where(r => r.Status == ReturnStatus.PENDING).ToListAsync();
            List<ReturnDetails> returndetails = new List<ReturnDetails>();
            if (returns != null)
            {
                foreach (var r in returns)
                {
                    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == r.UserID);
                    var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == r.ProductID);
                    var details = new ReturnDetails
                    {
                        Status = r.Status,
                        ReturnID = r.ReturnID,
                        ReturnQuantity =  r.Quantity,
                        User = user,
                        DateReturned = r.DateReturned,
                        ProductName = product.ProductName
                    };
                    
                    returndetails.Add(details);
                }

                return View(returndetails);

            }

            return View(returndetails);
        }

    }
}