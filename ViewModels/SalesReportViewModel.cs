using System;
using System.Collections.Generic;
using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class SalesReportViewModel
    {
        public List<SalesDetails> Sales { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

//        public Decimal Total
//        {
//            get
//            {
//                if (Sales != null)
//                {
//                    decimal total = 0;
//                    foreach (var s in Sales)
//                    {
//                        total += s.TotalPrice;
//                    }
//                }
//
//                return Total;
//            }
//        }

    }
}