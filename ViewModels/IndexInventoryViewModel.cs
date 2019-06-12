using System;

namespace EdmanOnlineShop.ViewModels
{
    public class IndexInventoryViewModel
    {
        public int InventoryID { get; set; }
        public int Quantity { get; set; }
        public int Critical { get; set; }
        public string  ProductName { get; set; }
        public DateTime InventoryDate { get; set; }
    }
}