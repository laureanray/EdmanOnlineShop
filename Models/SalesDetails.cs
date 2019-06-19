using System;

namespace EdmanOnlineShop.Models
{
    public class SalesDetails
    {
        public string CustomerName { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public Status Status { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime DateOrdered { get; set; }
        public string ProductName { get; set; }
    }
}