using System.Collections.Generic;
using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class IndexUserViewModel
    {
        public List<ApplicationUserDetails> Users { get; set; }
        public string UserID { get; set; }
        public string Role { get; set; }
        public string OldRole { get; set; }
    }
}