using System;
using System.Collections.Generic;
using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class IndexOrderViewModel
    {
        public List<OrderDetails> Orders { get; set; }
        
        // this will be used for approving and rejecting order
        public DateTime DeliverDate { get; set; }
        public int OrderID { get; set; }
        
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}