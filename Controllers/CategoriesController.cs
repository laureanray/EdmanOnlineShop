using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdmanOnlineShop.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _context.Categories.ToListAsync();
            CategoryViewModel vm = new CategoryViewModel();
            vm.Categories = new List<Category>();
            
            if (categories != null)
            {
                foreach (var category in categories)
                {
                    vm.Categories.Add(category);
                }

                return View(vm);
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            CategoryViewModel vm = new CategoryViewModel();

            var category = await _context.Categories.FirstOrDefaultAsync(ct => ct.CategoryID == id);
            var categories = await _context.Categories.ToListAsync();
            vm.Categories = new List<Category>();
            
            if (categories != null)
            {
                foreach (var cat in categories)
                {
                    vm.Categories.Add(cat);
                }

                if (category != null)
                {
                    vm.CategoryID = id;
                    vm.CategoryName = category.CategoryName;
                }


                return View(vm);

            }

            return View();

        }

        [HttpPost, ActionName("Edit")]
        public async Task<IActionResult> EditConfirm(int id, CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Categories = new List<Category>();
                    var category = await _context.Categories.FirstOrDefaultAsync(pd => pd.CategoryID == id);
                    if (category != null)
                    {
                        category.CategoryName = model.CategoryName;

                        _context.Entry(category).State = EntityState.Modified;

                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));

                    }

                    return NotFound();
                }
                catch (DbUpdateException)
                {

                }
            }

            return View(model);
        }
        
        [HttpPost, ActionName("Add")]
        public async Task<IActionResult> Add(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var category = new Category
                    {
                        CategoryName = model.CategoryName
                    };

                    _context.Categories.Add(category);

                    await _context.SaveChangesAsync();



                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException)
                {

                }
            }

            return RedirectToAction(nameof(Index));
        }
    }
}