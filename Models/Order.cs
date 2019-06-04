using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdmanOnlineShop.Models
{
    public enum PaymentMethod
    {
        CASH_ON_DELIVERY,
        CREDIT_CARD,
        BANK_TO_BANK,
        CHECK
    }

    public enum Status
    {
        PLACED,
        PROCESSED,
        SHIPPED,
        DELIVERED
    }
    public class Order
    {
            public int OrderID { get; set; }
            public int UserID { get; set; }
            public int ProductID { get; set; }
            public int Quantity { get; set; }
            [Column(TypeName = "decimal(18,2)")]
            public decimal Amount { get; set; }
            public Status Status { get; set; }
            public DateTime DateOrdered { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
    }
}