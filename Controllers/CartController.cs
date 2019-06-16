using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdmanOnlineShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public CartController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        
        public async Task<IActionResult> Index()
        {
            CartViewModel vm = new CartViewModel();
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = user.Id;
            vm.CartItems = new List<CartItemViewModel>();
            var cartItems = await _context.CartItems.Where(ci => ci.UserID == userId && ci.IsRequested == false).ToListAsync();
            if (cartItems != null)
            {
                foreach (var ci in cartItems)
                {
                    var ProductID = ci.ProductID;

                    var Product = await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == ProductID);
                    var inventory =
                        await _context.Inventories.FirstOrDefaultAsync(i => i.ProductID == Product.ProductID);
                    vm.CartItems.Add(new CartItemViewModel
                    {
                        Price = Product.Price,
                        Quantity = ci.Quantity,
                        ProductDescription = Product.ProductDescription,
                        ProductName = Product.ProductName,
                        ProductID = Product.ProductID,
                        ProductImage = Product.ProductImage,
                        Inventory = inventory,
                        CartItemID = ci.CartItemID
                    });
                }

                return View(vm);
            }

            return View();
        }

        public async Task<IActionResult> DeleteFromCart(int productId)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }


            var cartItem = await _context.CartItems.FirstOrDefaultAsync(ci => ci.ProductID == productId);

            if (cartItem == null)
            {
                return NotFound();
            }

            _context.CartItems.Remove(cartItem);

            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateQuantity(int productId, int quantity)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }
            var cartItem = await _context.CartItems.FirstOrDefaultAsync(ci => ci.ProductID == productId);

            if (cartItem == null)
            {
                return NotFound();
            }

            cartItem.Quantity = quantity;

            _context.Entry(cartItem).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            
            return RedirectToAction(nameof(Index));
        }

       

        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> AddToCart(int productId)
        {
            if (!_signInManager.IsSignedIn(User))
            {
                return RedirectToPage("/Identity/Account/Login");
            }
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return RedirectToAction(nameof(Index));
            }

            var userId = user.Id;
            var cartItemCheck = await _context.CartItems.FirstOrDefaultAsync(ci => ci.ProductID == productId);

            if (cartItemCheck != null)
            {
                cartItemCheck.Quantity = cartItemCheck.Quantity + 1;
                _context.Entry(cartItemCheck).State = EntityState.Modified;

                await _context.SaveChangesAsync();
            }
            else
            {
                var cartItem = new CartItem
                {
                    Quantity = 1,
                    ProductID = productId,
                    UserID = userId
                };

                _context.CartItems.Add(cartItem);
                await _context.SaveChangesAsync();
            }
            
      
            return RedirectToAction(nameof(Index));
        }
    }
}