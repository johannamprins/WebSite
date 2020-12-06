using System;
using System.Collections.Generic;
using System.Text;

namespace WebSite1
{
    public class Product
    {
        public int ProductId
        {
            get => default;
            set
            {
            }
        }

        public decimal ProductPrice
        {
            get => default;
            set
            {
            }
        }

        public string ProductType
        {
            get => default;
            set
            {
            }
        }

        public LineItem LineItem
        {
            get => default;
            set
            {
            }
        }

        public Admin Admin
        {
            get => default;
            set
            {
            }
        }

        public void AddProduct()
        {
            throw new System.NotImplementedException();
        }

        public void ModifyProduct()
        {
            throw new System.NotImplementedException();
        }

        public void selectProduct(int ProductId)
        {
            throw new System.NotImplementedException();
        }
    }
}