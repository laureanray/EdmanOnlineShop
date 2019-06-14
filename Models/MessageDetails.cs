using System;
using System.ComponentModel.DataAnnotations;

namespace EdmanOnlineShop.Models
{
    public class MessageDetails
    {
        public int MessageID { get; set; }
        public string FromUserID { get; set; }
        public string ToUserID { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string MessageContent { get; set; }
        public ApplicationUser FromUser { get; set; }
        public ApplicationUser ToUser { get; set; }
        public DateTime DateCreated { get; set; }
    }
}