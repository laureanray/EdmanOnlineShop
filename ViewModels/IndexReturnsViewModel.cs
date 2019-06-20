using System;
using System.Collections.Generic;
using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class IndexReturnsViewModel
    {
        public List<ReturnDetails> Returns { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

    }
}