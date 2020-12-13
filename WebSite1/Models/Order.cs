using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebSite1.Models;

namespace WebSite1.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Street Address")]
        [StringLength(100)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter your state")]
        [StringLength(2, MinimumLength = 2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter your zip")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter your phone")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }


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

        [BindNever]
        public DateTime OrderPlaced { get; set; }

        [BindNever]
        public decimal OrderTotal { get; set; }

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