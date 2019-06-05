namespace EdmanOnlineShop.ViewModels
{
    public class CartViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int CartViewID { get; set; }
        public int Quantity { get; set; }
        public decimal ProductPrice { get; set; }
    }
}