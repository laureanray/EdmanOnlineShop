using System;

namespace EdmanOnlineShop.Models
{
    public class Return
    {
        public int ReturnID { get; set; }
        public int ProductID { get; set; }
        public string UserID { get; set; }
        public int Quantity { get; set; }
        public DateTime DateReturned { get; set; }
        
    }
}