using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class CartItemViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int CartItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public byte[] ProductImage { get; set; }
        
        public Inventory Inventory { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }
}