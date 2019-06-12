using System.ComponentModel.DataAnnotations;

namespace EdmanOnlineShop.ViewModels
{
    public class RestockInventoryViewModel
    {
        public int InventoryID { get; set; }
        [Required]
        [Range(0,100000)]
        public int Quantity { get; set; }
        [Required]
        public int Critical { get; set; }
        public string  ProductName { get; set; }
    }
}