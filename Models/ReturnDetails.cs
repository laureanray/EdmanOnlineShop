using System;

namespace EdmanOnlineShop.Models
{
    public class ReturnDetails
    {
        public int ReturnID { get; set; }
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public int ReturnQuantity { get; set; }
        public DateTime DateReturned { get; set; }
        public ReturnStatus Status { get; set; }
        public byte[] ProductImage { get; set; }
        
        public Decimal TotalPrice { get; set; }
        public ApplicationUser User { get; set; }
    }
}