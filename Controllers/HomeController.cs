using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using Microsoft.AspNetCore.Mvc;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace EdmanOnlineShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ProductsViewModel vm = new ProductsViewModel();
            vm.Products = new List<ProductDetails>();
            
            var products = await _context.Products.Distinct().OrderByDescending(d => d.DateAdded).Take(4).ToListAsync();

            if (products != null)
            {
                foreach(var product in products)
                {
                    var category =
                        await _context.Categories.FirstOrDefaultAsync(c => c.CategoryID == product.CategoryID);
                    var details = new ProductDetails
                    {
                        Product = product,
                        Category = category
                    };
                    vm.Products.Add(details);
                }
                
                return View(vm);
            }
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
