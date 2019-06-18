using System.ComponentModel.DataAnnotations;

namespace EdmanOnlineShop.ViewModels
{
    public class WriteFeedbackViewModel
    {
        [Required]
        public string FeedbackMessage { get; set; }
        
        public int ProductID { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Please enter a number value between 0 and 5")]
        public int Rating { get; set; }
    }
}