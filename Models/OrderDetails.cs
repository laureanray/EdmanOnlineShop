using System;

namespace EdmanOnlineShop.Models
{
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public Status Status { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ProductID { get; set; }
        public DateTime DatePlaced { get; set; }
        
        public byte[] ProductImage { get; set; }

        public decimal Price { get; set; }
        public DateTime DeliverDate { get; set; }
    }
}