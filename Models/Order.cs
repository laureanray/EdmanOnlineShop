using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdmanOnlineShop.Models
{
    public enum PaymentMethod
    {
        CASH_ON_DELIVERY,
        PAYPAL
    }

    public enum Status
    {
        PENDING,
        TO_RECEIVE,
        REJECTED,
        CANCELLED,
        DELIVERED
    }
    public class Order
    {
            public int OrderID { get; set; }
            public string UserID { get; set; }
            public int ProductID { get; set; }
            public int Quantity { get; set; }
            [Column(TypeName = "decimal(18,2)")]
            public decimal Amount { get; set; }
            public Status Status { get; set; }
            public DateTime DateOrdered { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
            public DateTime DateToDeliver { get; set; }
            public DateTime DateDelivered { get; set; }

            public bool IsRequested { get; set; }
    }
}