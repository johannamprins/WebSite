using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WebSite1.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>
                ()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CardId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId};
        }

        public void AddToCart(Item item, int amount)
        {
            var shoppingCardItem = _appDbContext.shoppingCartItems.SingleOrDefault(
                s => s.Item.ItemId == item.ItemId && s.ShoppingCartId == ShoppingCartId);


            if (shoppingCardItem == null)
            {
                shoppingCardItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Item = item,
                    Amount = amount
                };

                _appDbContext.shoppingCartItems.Add(shoppingCardItem);
            }
            else
            {
                shoppingCardItem.Amount++;
            }

            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Item item)
        {
            var shoppingCardItem = _appDbContext.shoppingCartItems.SingleOrDefault(
                s => s.Item.ItemId == item.ItemId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCardItem != null)
            {
                if (shoppingCardItem.Amount > 1)
                {
                    shoppingCardItem.Amount--;
                    localAmount = shoppingCardItem.Amount;
                }
                else
                {
                    _appDbContext.shoppingCartItems.Remove(shoppingCardItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }
        public List<ShoppingCartItem> getShoppingCartItems()
        {
            return getShoppingCartItems() ?? (ShoppingCartItems = _appDbContext.shoppingCartItems.Where
                    (c => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Item)
                .ToList());
        }
        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.
                Where(c => c.ShoppingCartId == ShoppingCartId);
            _appDbContext.shoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }
        public decimal GetShoppingTotal()
        {
            var total = _appDbContext.shoppingCartItems.
                Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Item.Price * c.Amount).Sum();
            return (decimal) total;
        }

    }
}
