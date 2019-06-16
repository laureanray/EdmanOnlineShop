using System.Collections.Generic;
using EdmanOnlineShop.Models;

namespace EdmanOnlineShop.ViewModels
{
    public class CheckoutViewModel
    {
        public List<CartItemViewModel> CartItems { get; set; }

        public decimal Total
        {
            get
            {
                decimal total = 0;


                if (CartItems != null)
                {
                    foreach (var ci in CartItems)
                    {
                        for (int i = 0; i < ci.Quantity; i++)
                        {
                            total += ci.Price;
                        }
                    }
                }

                return total;
            }
            
        }

        public PaymentMethod PaymentMethod { get; set; }
    }
}