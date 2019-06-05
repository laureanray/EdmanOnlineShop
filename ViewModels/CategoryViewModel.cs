using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryID { get; set; }
        public List<Category> Categories { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}