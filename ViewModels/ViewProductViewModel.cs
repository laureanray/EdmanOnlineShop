namespace EdmanOnlineShop.ViewModels
{
    public class ViewProductViewModel
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public byte[] ProductImage { get; set; }
        public int CategoryID { get; set; }
        public int CategoryName { get; set; }
        public int StocksLeft { get; set; }
        public decimal Price { get; set; }
        public int Critical { get; set; }
        
    }
}