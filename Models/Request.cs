using System;

namespace EdmanOnlineShop.Models
{

    public enum RequestStatus
    {
        PENDING,
        APPROVED,
        REJECTED
    }

    public class Request
    {
        public int RequestID { get; set; }
        public DateTime RequestDate { get; set; }
        public string UserID { get; set; }
        public int CartItemID { get; set; }
        public RequestStatus RequestStatus { get; set; }

    }
}