using System;

namespace EdmanOnlineShop.Models
{
    public class Request
    {
        public int RequestID { get; set; }
        public int UserID { get; set; }
        public string RequestHeader { get; set; }
        public string RequestDetails { get; set; }
        public DateTime RequestDate { get; set; }
        public int ProductID { get; set; }
    }
}