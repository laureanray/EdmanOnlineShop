using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;


namespace EdmanOnlineShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }
        [Authorize(Roles = "Admin, SalesClerk")]
        public async Task<IActionResult> ProductsTable()
        {
            return View(await _context.Products.ToListAsync());
        }
    
        public async Task<IActionResult> ViewProduct(int productId)
        {
            return View(await _context.Products.SingleOrDefaultAsync(product => product.ProductID == productId));
        }
        [Authorize(Roles = "Admin, SalesClerk")]
        
        [HttpGet]
        public async  Task<IActionResult> Add()    
        {
            AddProductViewModel vm = new AddProductViewModel();
            vm.Categories = await _context.Categories.ToListAsync();
            return View(vm);
        }
        
        [HttpGet]
        public async Task<IActionResult> Delete(int? productId)
        {
            if (productId == null)
            {
                return NotFound();
            }

            var product = await _context.Products.AsNoTracking().FirstOrDefaultAsync(p => p.ProductID == productId);

            if (product == null)
            {
                return NotFound();
            }
            
            DeleteProductViewModel vm = new DeleteProductViewModel();
            vm.ProductName = product.ProductName;
            vm.ProductID = product.ProductID;


            return View(vm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            try
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ProductsTable));

            }
            catch (DbUpdateException)
            {
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });

            }
        }
        
        [HttpGet]
        public async Task<IActionResult> Edit(int? productId)    
        {
            if (productId == null)
            {
                return NotFound();
            }
            EditProductViewModel vm = new EditProductViewModel();
            
            if (ModelState.IsValid)
            {
              
                    var res = await _context.Products.FirstOrDefaultAsync(p => p.ProductID == productId);
                    var categories = await _context.Categories.ToListAsync();
                    vm.ProductName = res.ProductName;
                    vm.ProductDescription = res.ProductDescription;
                    vm.Price = res.Price;
                    vm.CategoryID = res.CategoryID;
                    vm.Categories = categories;
                    vm.ProductID = res.ProductID;
                    
                    
                    
                    return View(vm);

              
            }

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditFinal(EditProductViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Console.WriteLine(id);
                    var product =  await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == id);
                    if (product != null)
                    {
                        product.Price = model.Price;
                        product.ProductDescription = model.ProductDescription;
                        product.ProductName = model.ProductName;
                        product.CategoryID = model.CategoryID;

                        if (model.ProductImage != null)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                await model.ProductImage.CopyToAsync(memoryStream);
                                product.ProductImage = memoryStream.ToArray();
                            }
                        }
                    

                     

                        _context.Entry(product).State = EntityState.Modified;
                    
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(ProductsTable));

                    }

                    return NotFound();

                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to save changes. " +
                                                 "Try again, and if the problem persists, " +
                                                 "see your system administrator.");
                    return View("Edit", model);

                }
            }

            return RedirectToAction(nameof(Edit));

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = new Product
                {
                    ProductName = model.ProductName,
                    ProductDescription = model.ProductDescription,
                    CategoryID = model.CategoryID,
                    Price = model.Price
                };

                if (model.ProductImage != null)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await model.ProductImage.CopyToAsync(memoryStream);
                        product.ProductImage = memoryStream.ToArray();
                    }

                }
                else
                {
                    product.ProductImage = DummyData.defaultImage;
                }
                
                _context.Products.Add(product);

                await _context.SaveChangesAsync();
                
                return RedirectToAction("ProductsTable");


            }
            
            Console.WriteLine(ModelState.Values.SelectMany(v => v.Errors));

            model.Categories = await _context.Categories.ToListAsync();
            return View(model);
        } 
    }
}