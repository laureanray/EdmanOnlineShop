//using System.Threading.Tasks;
//using EdmanOnlineShop.Data;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//
//namespace EdmanOnlineShop.Controllers
//{
//    public class CartController
//    {
//        private readonly ApplicationDbContext _context;
//
//        public CartController(ApplicationDbContext context)
//        {
//            _context = context;
//        }
//
//       public async Task<IActionResult> Index()
//       {
//           var cartItems = _context.CartItems.ToListAsync();
//
//           if (cartItems != null)
//           {
//               
//           }
//    }
//}