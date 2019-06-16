using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class FeedBackViewModel
    {
        public List<MessageDetails> Messages { get; set; }
        public List<MessageDetails> ArchivedMessages { get; set; }

        public string UserID { get; set; }
        [Required]
        public string FeedbackMessage { get; set; }
        public ApplicationUser User { get; set; }
    }
}