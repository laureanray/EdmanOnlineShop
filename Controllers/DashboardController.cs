using System;
using System.Linq;
using System.Threading.Tasks;
using EdmanOnlineShop.Data;
using EdmanOnlineShop.Models;
using EdmanOnlineShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EdmanOnlineShop.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public DashboardController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Authorize(Roles="Admin, SalesClerk, OperationsManager, Accounting, InternationalCorrespondenceAndSecretary, LogisticsClerk")]
        public async Task<IActionResult> Index()
        {
            DashboardViewModel vm = new DashboardViewModel();
            DateTime startDateTime = DateTime.Today;
            DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1);
            var ordersSoldToday = await 
                _context.Orders.Where(o => o.Status == Status.DELIVERED).Where(o => o.DateDelivered >= startDateTime && o.DateDelivered <= endDateTime)
                    .ToListAsync();

            if (ordersSoldToday != null)
            {               
                int quantitySoldToday = 0;
                decimal totalSalesToday = 0;
                foreach (var order in ordersSoldToday)
                {
                    quantitySoldToday += order.Quantity;
                    totalSalesToday += order.Amount;
                }

                vm.QuantitySoldToday = quantitySoldToday;
                vm.TotalSalesToday = totalSalesToday;
            }

            var totalOrders = await _context.Orders.CountAsync();
            var processedOrders = await _context.Orders.Where(o => o.Status != Status.PENDING).CountAsync();

            float progress = (processedOrders / (float) totalOrders) * 100;

            vm.OrderProgress = Convert.ToInt32(Math.Round(progress));

            var numOfNewUsers =
                await _context.Users.Where(u => u.DateRegistered >= startDateTime && u.DateRegistered <= endDateTime)
                    .CountAsync();

            vm.NumOfNewRegisterToday = numOfNewUsers;



            return View(vm);
        }
        
    }
}