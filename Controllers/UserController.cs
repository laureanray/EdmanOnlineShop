using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdmanOnlineShop.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUserRole(IndexUserViewModel model)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == model.UserID);

            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, model.Role);
                await _userManager.RemoveFromRoleAsync(user, model.OldRole);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> DeactivateAccount(IndexUserViewModel model)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == model.UserID);

            if (user != null)
            {
                user.IsActive = false;
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        
        [HttpPost]
        public async Task<IActionResult> ReactivateAccount(IndexUserViewModel model)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == model.UserID);

            if (user != null)
            {
                user.IsActive = true;
                _context.Entry(user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Index()
        {
            var users = await _context.Users.ToListAsync();

            var vm = new IndexUserViewModel();
            vm.Users = new List<ApplicationUserDetails>();
            if (users != null)
            {
                foreach (var u in users)
                {
                    var role = await _userManager.GetRolesAsync(u);
                    string roles = "";

                    if (role != null)
                    {
                        foreach (var r in role)
                        {
                            roles += r;
                        }
                    }

                    ApplicationUserDetails details = new ApplicationUserDetails
                    {
                        FirstName = u.FirstName,
                        LastName = u.LastName,
                        UserGender = u.UserGender,
                        Role = roles,
                        Email = u.Email,
                        Id = u.Id,
                        IsActive = u.IsActive
                    };
                    vm.Users.Add(details);
                }
            }

            return View(vm);
        }
    }
}