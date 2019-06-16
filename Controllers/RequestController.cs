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
    public class RequestController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        
        public RequestController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = user.Id;
            var requests = await _context.Requests.Where(r => r.UserID == userId).ToListAsync();
            RequestViewModel vm = new RequestViewModel();
            vm.Requests = new List<RequestDetails>();

            if (requests != null)
            {
                foreach (var r in requests)
                {
                    var cartItem = await _context.CartItems.FirstOrDefaultAsync(c => c.CartItemID == r.CartItemID);
                    var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == cartItem.ProductID);
                    var requestDetails = new RequestDetails
                    {
                        Price = product.Price,
                        DateRequested = r.RequestDate,
                        ProductImage = product.ProductImage,
                        ProductName = product.ProductName,
                        ProuductDescription = product.ProductDescription,
                        RequestStatus = r.RequestStatus,
                        CartItemID = cartItem.CartItemID,
                        ProductID = product.ProductID,
                        RequestID = r.RequestID
                    };
                    
                    vm.Requests.Add(requestDetails);
                }

                return View(vm);
            }

            return View();
        }

        

        public async Task<IActionResult> RequestConfirm(int cartItemID)
        {
            var cartItem = await _context.CartItems.FirstOrDefaultAsync(c => c.CartItemID == cartItemID);
            RequestConfirmViewModel vm = new RequestConfirmViewModel();

            if (cartItem == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == cartItem.ProductID);

            if (product == null)
            {
                return NotFound();
            }

            vm.Quantity = cartItem.Quantity;
            vm.ProductName = product.ProductName;
            vm.CartitemID = cartItem.CartItemID;
            vm.ProductImage = product.ProductImage;

            return View(vm);

        }
        
        public async Task<IActionResult> AddRequest(int cartItemID)
        {

                var cartItem = await _context.CartItems.FirstOrDefaultAsync(c => c.CartItemID == cartItemID);
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == cartItem.UserID);
                if (cartItem != null)
                {
                    var request = new Request
                    {
                        RequestDate = DateTime.Now,
                        CartItemID = cartItem.CartItemID,
                        RequestStatus = RequestStatus.PENDING,
                        UserID = user.Id
                    };

                    _context.Requests.Add(request);

                    cartItem.IsRequested = true;
                    _context.Entry(cartItem).State = EntityState.Modified;
                    

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

                return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> RequestTable()
        {
            var requests = await _context.Requests.Where(r => r.RequestStatus == RequestStatus.PENDING).ToListAsync();
            RequestTableViewModel vm = new RequestTableViewModel();
            vm.Requests = new List<RequestDetails>();
            if (requests != null)
            {
                foreach (var req in requests)
                {
                    var cartItem = await _context.CartItems.FirstOrDefaultAsync(c => c.CartItemID == req.CartItemID);
                    var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == cartItem.ProductID);
                    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == cartItem.UserID);
                    var requestDetails = new RequestDetails
                    {
                        ProductName = product.ProductName,
                        ProductID = product.ProductID,
                        Price = product.Price,
                        DateRequested = req.RequestDate,
                        ProuductDescription = product.ProductDescription,
                        ProductImage = product.ProductImage,
                        RequestStatus = req.RequestStatus,
                        RequestID = req.RequestID,
                        CartItemID = cartItem.CartItemID,
                        User = user
                    };
                    
                    vm.Requests.Add(requestDetails);
                }

                    return View(vm);
            }

            return View();
            
        }

        public async Task<IActionResult> Approve(int id)
        {
            var request = await _context.Requests.FirstOrDefaultAsync(r => r.RequestID == id);

            if (request != null)
            {
                request.RequestStatus = RequestStatus.APPROVED;
                _context.Entry(request).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(RequestTable));
            }

            return NotFound();
        }
        
        public async Task<IActionResult> Reject(int id)
        {
            var request = await _context.Requests.FirstOrDefaultAsync(r => r.RequestID == id);

            if (request != null)
            {
                request.RequestStatus = RequestStatus.REJECTED;
                _context.Entry(request).State = EntityState.Modified;

                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(RequestTable));
            }

            return NotFound();
        }
    }
}