//using System.Threading.Tasks;
//using EdmanOnlineShop.Data;
//using EdmanOnlineShop.ViewModels;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//
//namespace EdmanOnlineShop.Controllers
//{
//    public class OrdersController : Controller
//    {
//
//        private readonly ApplicationDbContext _context;
//
//        public OrdersController(ApplicationDbContext context)
//        {
//            _context = context;
//
//        }
//
////        public async Task<IActionResult> Index()
////        {
////            
////        }
//
//
//        public async Task<IActionResult> AddOrder(CartViewModel vm)
//        {
//            await _context.Orders.ToListAsync();
//            return View();
//        }
//    }
//}