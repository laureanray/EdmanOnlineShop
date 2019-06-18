using System.Collections.Generic;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        
        public async Task<IActionResult> ProductsReport()
        {
            var products = await _context.Products.ToListAsync();
            var model = new ProductsReportViewModel();
            model.Products = new List<ProductDetails>();

            if (products != null)
            {
                foreach (var p in products)
                {
                    var category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryID == p.CategoryID);

                    model.Products.Add(new ProductDetails
                    {
                        Category = category,
                        Product = p
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