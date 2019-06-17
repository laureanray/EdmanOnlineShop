namespace EdmanOnlineShop.Models
{
    public class Notification
    {
        public string NotificationHeader { get; set; }
        public string ProductName { get; set; }
        public int StocksLeft { get; set; }
        public byte[] ProductImage { get; set; }
    }
}