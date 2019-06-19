using System;
using System.ComponentModel.DataAnnotations;

namespace EdmanOnlineShop.ViewModels
{
    public enum Report
    {
        DELIVERY,
        SALES,
        INVENTORY,
        RETURN,
        REQUEST
    }
    
    public class ReportsViewModel 
    {
        [Required]
        public Report Report { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        
    }
}