  using System;
  using System.Collections.Generic;
  using System.Globalization;
  using System.Text;
  using ApplicationCore.Entities.Customer;
  using Microsoft.AspNetCore.Http;
  using Microsoft.Extensions.DependencyInjection;

namespace ApplicationCore.Entities.Basket
{
    public class ShoppingCart
    {

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }


        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>
                ()?.HttpContext.Session;

            return new ShoppingCart();
        }
    }
}
