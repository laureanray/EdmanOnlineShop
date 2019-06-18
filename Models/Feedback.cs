using System;

namespace EdmanOnlineShop.Models
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int ProductID { get; set; }
        public string UserID { get; set; }
        public string FeedbackMessage { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsArchived { get; set; }
        public int Rating { get; set; }
    }
}