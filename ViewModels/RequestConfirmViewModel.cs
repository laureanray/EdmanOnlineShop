using System;
using System.ComponentModel.DataAnnotations;
using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class RequestConfirmViewModel
    {
        public string UserID { get; set; }
        public DateTime RequestDate { get; set; }
        public int CartitemID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public byte[] ProductImage { get; set; }
    }
}