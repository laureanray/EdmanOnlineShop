using System;

namespace EdmanOnlineShop.Models
{
    public class Inventory 
    {
        public int InventoryID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int CriticalLevel { get; set; }
        public DateTime InventoryDate { get; set; }
        
        public Product Product { get; set; }
    }
}