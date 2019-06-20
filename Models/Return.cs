using System;

namespace EdmanOnlineShop.Models
{

    public enum ReturnStatus
    {
        PENDING,
        RETURNED,
        REJECTED
    }
    public class Return
    {
        public int ReturnID { get; set; }
        public int ProductID { get; set; }
        public string UserID { get; set; }
        public int Quantity { get; set; }
        public DateTime DateReturned { get; set; }
        public ReturnStatus Status { get; set; }
        public int OrderID { get; set; }
    }
}