using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class ReturnConfirmViewModel
    {
        public int OrderID { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}