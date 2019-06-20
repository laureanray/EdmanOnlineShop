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
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace EdmanOnlineShop.Controllers
{

    public class OrdersController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public OrdersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize(Roles = "Admin, SalesClerk, LogisticsClerk, OperationsManager")]

        public async Task<IActionResult> Index()
        {
            var orders = await _context.Orders.Where(o => o.Status == Status.PENDING).ToListAsync();
            IndexOrderViewModel vm = new IndexOrderViewModel();
            vm.Orders = new List<OrderDetails>();
            if (orders != null)
            {
                foreach (var order in orders)
                {
                    var product = await _context.Products.FirstOrDefaultAsync(pd =>
                        pd.ProductID == order.ProductID);

                    var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == order.UserID);
                    
                    
                    
                    var od = new OrderDetails
                    {
                        Amount = order.Amount,
                        Quantity = order.Quantity,
                        Status = order.Status,
                        PaymentMethod = order.PaymentMethod,
                        ProductName = product.ProductName,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        ProductID = product.ProductID,
                        OrderID = order.OrderID
                    };

                    vm.Orders.Add(od);
                }

                return View(vm);
            }

            return NotFound();
        }

        [Authorize(Roles = "Admin, SalesClerk, LogisticsClerk, OperationsManager")]

        [HttpPost]
        public async Task<IActionResult> Approve(IndexOrderViewModel model)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == model.OrderID);

            if (order != null)
            {
                order.Status = Status.TO_RECEIVE;
                order.DateToDeliver = model.DeliverDate;
                _context.Entry(order).State = EntityState.Modified;
                // update inventory
                var inventory =
                    await _context.Inventories.FirstOrDefaultAsync(iv => iv.ProductID == order.ProductID);

                if (inventory != null)
                {
                    // deduct the order
                    if (inventory.Quantity > 0 && (order.Quantity <= inventory.Quantity) && order.IsRequested == false)
                    {
                        inventory.Quantity -= order.Quantity;
                        _context.Entry(inventory).State = EntityState.Modified;
                    }
                    else if(!order.IsRequested){
                        return Unauthorized();

                    }
                    
                }
                
                await _context.SaveChangesAsync();

            }
            
           

            return RedirectToAction(nameof(Index));
        }
        
        [Authorize(Roles = "Admin, SalesClerk, LogisticsClerk, OperationsManager")]

        public async Task<IActionResult> Reject(int orderId)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(o => o.OrderID == orderId);

            if (order != null)
            {
                order.Status = Status.REJECTED;
                _context.Entry(order).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        
        [Authorize(Roles = "Customer")]
   
        public async Task<IActionResult> MyOrders()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = user.Id;
            var orders = await _context.Orders.Where(o => o.UserID == userId).ToListAsync();
            IndexOrderViewModel vm = new IndexOrderViewModel();
            vm.Orders = new List<OrderDetails>();
            if (orders != null)
            {
                foreach (var order in orders)
                {
                    var Product = await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == order.ProductID);
                    var return_ = await _context.Returns.FirstOrDefaultAsync(r => r.OrderID == order.OrderID);
                    var returnQty = -1;
                    if(return_ != null)
                    {
                        returnQty = return_.Quantity;
                    }
                    var x = order.DateToDeliver;
                    var od = new OrderDetails
                    {
                        Amount = order.Amount,
                        Quantity = order.Quantity,
                        Status = order.Status,
                        PaymentMethod = order.PaymentMethod,
                        ProductName = Product.ProductName,
                        OrderID = order.OrderID,
                        DatePlaced = order.DateOrdered,
                        ProductImage = Product.ProductImage,
                        DeliverDate = order.DateToDeliver,
                        ProductID =  Product.ProductID,
                        ReturnQuantity = returnQty,
                        CanBeReturnedUntil = order.DateDelivered.AddDays(7)

                    };
                    
                    vm.Orders.Add(od);
                }

                return View(vm);
            }

            return View();
        }
        
        [Authorize(Roles = "Customer")]

        [HttpPost]
        public async Task<IActionResult> AddOrder(CheckoutViewModel viewModel)
        {
//            if (ModelState.IsValid)
//            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var userId = user.Id;
                var cartItems = await _context.CartItems.Where(ci => ci.UserID == userId && !ci.IsRequested).ToListAsync();
                if (cartItems.Count > 0)
                {
                    foreach (var cartItem in cartItems)
                    {
                        var product = await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == cartItem.ProductID);
                        var inventory = await _context.Inventories.FirstOrDefaultAsync(i => i.ProductID == cartItem.ProductID);
                        
                        if (cartItem.Quantity <= inventory.Quantity)
                        {
                            var order = new Order
                            {
                                Amount = product.Price * cartItem.Quantity,
                                Quantity = cartItem.Quantity,
                                Status = Status.PENDING,
                                DateOrdered = DateTime.Now,
                                PaymentMethod = viewModel.PaymentMethod,
                                ProductID = cartItem.ProductID,
                                UserID = userId
                            };
                            
                            
                            _context.CartItems.Remove(cartItem);
                            _context.Orders.Add(order);
                        }


                      
                      
                    }

                    await _context.SaveChangesAsync();
                }


                return RedirectToAction(nameof(MyOrders));
            
        }
        
        [Authorize(Roles = "Customer")]

        [HttpPost]
        public async Task<IActionResult> AddOrderRequest(CartItemViewModel viewModel)
        {
//            if (ModelState.IsValid)
//            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var userId = user.Id;
                var cartItem = await _context.CartItems.FirstOrDefaultAsync(c => c.CartItemID == viewModel.CartItemID);

                if (cartItem != null)
                {
                    var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == cartItem.ProductID);
                    var request = await _context.Requests.FirstOrDefaultAsync(r => r.CartItemID == cartItem.CartItemID);
                    var order = new Order
                    {
                        Amount = product.Price * cartItem.Quantity,
                        Quantity = cartItem.Quantity,
                        Status = Status.PENDING,
                        DateOrdered = DateTime.Now,
                        IsRequested = true,
                        PaymentMethod = viewModel.PaymentMethod,
                        ProductID = product.ProductID,
                        UserID = userId
                    };

                    _context.Orders.Add(order);
                    _context.CartItems.Remove(cartItem);
                    _context.Requests.Remove(request);

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(MyOrders));
                }

                return View("CheckoutRequestedProduct", viewModel);

//            }

//            return View("Checkout");
        }

        [Authorize(Roles = "Customer")]

        public async Task<IActionResult> CheckoutRequestedProduct(int cartItemId)
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            var userId = user.Id;
            var cartItem = await _context.CartItems.FirstOrDefaultAsync(c => c.CartItemID == cartItemId);
            if (cartItem != null)
            {
                    

                    var Product = await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == cartItem.ProductID);

                    var vm = new CartItemViewModel
                    {
                        Price = Product.Price,
                        Quantity = cartItem.Quantity,
                        ProductDescription = Product.ProductDescription,
                        ProductName = Product.ProductName,
                        ProductID = Product.ProductID,
                        ProductImage = Product.ProductImage,
                        CartItemID = cartItemId
                    };
                

                return View(vm);
            }
            
            return View();   
        }

        [Authorize(Roles = "Customer")]

        public async Task<IActionResult> Checkout()
        {
            CheckoutViewModel vm = new CheckoutViewModel();
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
                    var inventory = await _context.Inventories.FirstOrDefaultAsync(i => i.ProductID == ci.ProductID);

                    if (ci.Quantity <= inventory.Quantity)
                    {
                        vm.CartItems.Add(new CartItemViewModel
                        {
                            Price = Product.Price,
                            Quantity = ci.Quantity,
                            ProductDescription = Product.ProductDescription,
                            ProductName = Product.ProductName,
                            ProductID = Product.ProductID,
                            ProductImage = Product.ProductImage
                        });                    }

                   
                }

                return View(vm);
            }
            
            return View();
            
        }
        
    }
}