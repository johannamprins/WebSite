using System;
using System.Collections.Generic;
using System.Text;
using WebSite1.Models;

namespace WebSite1.Models
{
    public class Order
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Aadress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }


        public int OrderId
        {
            get => default;
            set
            {
            }
        }

        public int CustomerId
        {
            get => default;
            set
            {
            }
        }

        public int CustomerName
        {
            get => default;
            set
            {
            }
        }

        public int ProductId
        {
            get => default;
            set
            {
            }
        }

        public float Amount
        {
            get => default;
            set
            {
            }
        }

        public DateTime OrderDate
        {
            get => default;
            set
            {
            }
        }

        public OrderStatus OrderStatus
        {
            get => default;
            set
            {
            }
        }

        public Payment Payment 
        {
            get => default;
            set
            {
            }
        }

        public DateTime OrderPlaced { get; internal set; }
        public decimal OrderTotal { get; internal set; }

        public void CreateOrder()
        {
            throw new System.NotImplementedException();
        }

        public void EditOrder(int OrderId)
        {
            throw new System.NotImplementedException();
        }
    }
}