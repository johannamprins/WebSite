using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities.Basket;

namespace ApplicationCore.Entities.Customer
{
    public class Account
    {
        public String accountID { get; set; }
        public DateTime dateOpened { get; set; }
        public BillingAddress billingAddress { get; set; }
        public int PhoneNumber;
        public string EmailAddress;
        public bool isAdmin;

        public bool IsAdmin
        {
            get => isAdmin;
            set => isAdmin = value;
        }

        public Order order { get; set; }

        public virtual ShoppingCart shoppingCart { get; set; }
    }

}
