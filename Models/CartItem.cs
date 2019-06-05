using System;

namespace EdmanOnlineShop.Models
{
    public class CartItem
    {
        public int CartItemID { get; set; }
        public string UserID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}