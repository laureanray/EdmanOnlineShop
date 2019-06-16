using System.Collections.Generic;
using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class ProductsViewModel
    {
        public List<ProductDetails> Products { get; set; }
        public List<Category> Categories { get; set; }
        public string SelectedCategory { get; set; }
        public string SearchQuery { get; set; }
    }
}