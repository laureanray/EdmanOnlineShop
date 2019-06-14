using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class FeedbackTableViewModel
    {
        public List<MessageDetails> Messages { get; set; } 
        public List<FeedbackDetails> Feedbacks { get; set; }
    }
}