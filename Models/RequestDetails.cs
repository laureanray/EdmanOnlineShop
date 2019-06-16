using System;

namespace EdmanOnlineShop.Models
{
    public class RequestDetails
    {
        public int CartItemID { get; set; }
        public int RequestID { get; set; }
        public RequestStatus RequestStatus { get; set; }
        public DateTime DateRequested { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProuductDescription { get; set; }
        public decimal Price { get; set; }
        public byte[] ProductImage { get; set; }
        public ApplicationUser User { get; set; }
    }
}