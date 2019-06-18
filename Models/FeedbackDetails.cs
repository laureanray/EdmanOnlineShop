using System;

namespace EdmanOnlineShop.Models
{
    public class FeedbackDetails
    {
        public int FeedbackID { get; set; }
        public ApplicationUser User { get; set; }
        public string FeedbackMessage { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsArchived { get; set; }
    }
}