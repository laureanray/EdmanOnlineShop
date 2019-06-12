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
    }
}