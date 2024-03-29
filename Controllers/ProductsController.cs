using System;
using System.Collections.Generic;
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
            
        [HttpPost]
        public async Task<IActionResult> Index(ProductsViewModel model)
        {
            ProductsViewModel vm = new ProductsViewModel();
            vm.Products = new List<InventoryDetails>();
            var products = _context.Products.Where(pd => pd.IsArchived == false);
            var categories = await _context.Categories.ToListAsync();
            vm.Categories = new List<Category>();
            vm.Categories = categories;
            vm.SearchQuery = model.SearchQuery;
            vm.SelectedCategory = model.SelectedCategory;
            if (!String.IsNullOrEmpty(model.SearchQuery) && !String.IsNullOrEmpty(model.SelectedCategory))
            {
                var selectedCategory = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryName == model.SelectedCategory);

                products = products.Where(p =>
                    p.ProductName.Contains(model.SearchQuery) && p.CategoryID == selectedCategory.CategoryID);
                ViewData["SearchResult"] = "Showing " + await products.CountAsync() + " results for \"" +
                                           model.SearchQuery + "\" under " + selectedCategory.CategoryName;

                foreach (var pd in products)
                {
                    var category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryID == pd.CategoryID);
                    var details = new InventoryDetails
                    {
                        Category = category,
                        Product = pd
                    };
                    vm.Products.Add(details);
                }


                return View(vm);
            }
            if (!String.IsNullOrEmpty(model.SearchQuery))
            {
                products = products.Where(p => p.ProductName.Contains(model.SearchQuery));
                ViewData["SearchResult"] = "Showing " + await products.CountAsync() + " results for \"" +
                                           model.SearchQuery + "\"";

                foreach (var pd in products)
                {
                    var category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryID == pd.CategoryID);
                    var details = new InventoryDetails
                    {
                        Category = category,
                        Product = pd
                    };
                    vm.Products.Add(details);
                }


                return View(vm);
            }


            if (!String.IsNullOrEmpty(model.SelectedCategory))
            {
                var selectedCategory = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryName == model.SelectedCategory);

                products = products.Where(p => p.CategoryID == selectedCategory.CategoryID);

                foreach (var p in products)
                {
                    var category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryID == p.CategoryID);
                    var details = new InventoryDetails
                    {
                        Category = category,
                        Product = p
                    };
                    vm.Products.Add(details);
                    
                }

                vm.SelectedCategory = selectedCategory.CategoryName;

                return View(vm);

            }

            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Index(string productName, string categoryFilter)
        {
            ProductsViewModel vm = new ProductsViewModel();
            vm.Products = new List<InventoryDetails>();
            var products = _context.Products.Where(pd => pd.IsArchived == false);
            var categories = await _context.Categories.ToListAsync();
            vm.Categories = new List<Category>();
            vm.Categories = categories;
            
            var productList = await _context.Products.Where(pd => pd.IsArchived == false).ToListAsync();
            if (productList != null)
            {
                foreach (var p in productList)
                {
                    var category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryID == p.CategoryID);
                    var details = new InventoryDetails
                    {
                        Category = category,
                        Product = p
                    };
                    vm.Products.Add(details);
                }

                return View(vm);
            }

            return NotFound();
        }

        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary")]
        public async Task<IActionResult> ProductsTable()
        {
            return View(await _context.Products.Where(pd => pd.IsArchived == false).ToListAsync());
        }

        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary")]

        public async Task<IActionResult> Archived()
        {
            return View(await _context.Products.Where(pd => pd.IsArchived == true).ToListAsync());
        }

        public async Task<IActionResult> ViewProduct(int productId)
        {
            ViewProductViewModel vm = new ViewProductViewModel();
            vm.Feedbacks = new List<FeedbackDetails>();
            var product = await _context.Products.SingleOrDefaultAsync(pd => pd.ProductID == productId);
            if (product != null)
            {
                var inventory = await _context.Inventories.SingleOrDefaultAsync(iv => iv.ProductID == productId);
                vm.ProductDescription = product.ProductDescription;
                vm.ProductName = product.ProductName;
                vm.ProductID = product.ProductID;
                vm.ProductImage = product.ProductImage;
                vm.StocksLeft = inventory.Quantity;
                vm.Price = product.Price;
                vm.Critical = inventory.CriticalLevel;

                var feedbacks = await _context.Feedbacks.Where(f => f.ProductID == productId).ToListAsync();

                if (feedbacks != null)
                {
                    foreach (var fb in feedbacks)
                    {
                        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == fb.UserID);
                        if (user != null)
                        {
                            vm.Feedbacks.Add(new FeedbackDetails
                            {
                                Rating = fb.Rating,
                                FeedbackMessage = fb.FeedbackMessage,
                                FeedbackID = fb.FeedbackID,
                                User = user,
                                DateCreated = fb.DateCreated,
                                IsArchived = fb.IsArchived
                            });
                        }
                    }
                }
                
                return View(vm);
            }

            return NotFound();
        }

        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            AddProductViewModel vm = new AddProductViewModel();
            vm.Categories = await _context.Categories.ToListAsync();
            return View(vm);
        }
        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary")]

        [HttpGet]
        public async Task<IActionResult> Archive(int? productId)
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

            ArchiveProductViewModel vm = new ArchiveProductViewModel();
            vm.ProductName = product.ProductName;
            vm.ProductID = product.ProductID;
            vm.ProductDescription = product.ProductDescription;


            return View(vm);
        }
        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary")]
        [HttpPost, ActionName("Archive")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ArchiveConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var product = await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == id);
                    if (product != null)
                    {
                        product.IsArchived = true;
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
                    return RedirectToAction(nameof(ProductsTable));
                }
            }

            return NotFound();
        }
        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary")]

        [HttpGet]
        public async Task<IActionResult> Restore(int? productId)
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

            ArchiveProductViewModel vm = new ArchiveProductViewModel();
            vm.ProductName = product.ProductName;
            vm.ProductID = product.ProductID;
            vm.ProductDescription = product.ProductDescription;


            return View(vm);
        }

        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary")]

        [HttpPost, ActionName("Restore")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RestoreConfirm(int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var product = await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == id);
                    if (product != null)
                    {
                        product.IsArchived = false;
                        product.DateModified = DateTime.Now;
                        _context.Entry(product).State = EntityState.Modified;
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Archived));
                    }

                    return NotFound();
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to save changes. " +
                                                 "Try again, and if the problem persists, " +
                                                 "see your system administrator.");
                    return RedirectToAction(nameof(Archived));
                }
            }

            return NotFound();
        }

        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary")]

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

        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary")]

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditFinal(EditProductViewModel model, int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Console.WriteLine(id);
                    var product = await _context.Products.FirstOrDefaultAsync(pd => pd.ProductID == id);
                    if (product != null)
                    {
                        product.Price = model.Price;
                        product.ProductDescription = model.ProductDescription;
                        product.ProductName = model.ProductName;
                        product.CategoryID = model.CategoryID;
                        product.DateModified = DateTime.Now;

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

        [Authorize(Roles = "Admin, SalesClerk, InternationalCorrespondenceAndSecretary")]

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
                    Price = model.Price,
                    DateAdded = DateTime.Now
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

                var inventory = new Inventory
                {
                    Quantity = 100,
                    CriticalLevel = 10,
                    InventoryDate = DateTime.Now,
                    Product = product
                };
                Console.WriteLine(product.ProductID);
                _context.Inventories.Add(inventory);

                await _context.SaveChangesAsync();


                return RedirectToAction("ProductsTable");
            }

            Console.WriteLine(ModelState.Values.SelectMany(v => v.Errors));

            model.Categories = await _context.Categories.ToListAsync();
            return View(model);
        }
    }
}