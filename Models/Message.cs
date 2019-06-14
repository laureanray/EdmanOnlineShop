using System;

namespace EdmanOnlineShop.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string FromUserID { get; set; }
        public string ToUserID { get; set; }
        public string MessageContent { get; set; }
        
        public DateTime DateCreated { get; set; }
    }
}