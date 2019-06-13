namespace EdmanOnlineShop.ViewModels
{
    public class DashboardViewModel
    {
        public int NumOfNewRegisterToday { get; set; }
        public int QuantitySoldToday { get; set; }
        public decimal TotalSalesToday { get; set; }
        public int OrderProgress { get; set; }
    }
}