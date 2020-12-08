using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.Extensions.DependencyInjection;

namespace WebSite1.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCardId { get; set; }
        public List<ShoppingCartItem> shoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>
                ()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cardId = session.GetString("CardId") ?? Guid.NewGuid().ToString();
            session.SetString("CardId", cardId);

            return new ShoppingCart(context) { ShoppingCardId = cardId};
        }

        public void AddToCart(Item item, int amount)
        {
            var shoppingCardItem = _appDbContext.shoppingCartItems.SingleOrDefault(
                s => s.Item.ItemId == item.ItemId && s.ShoppingCartId == ShoppingCardId);


            if (shoppingCardItem == null)
            {
                shoppingCardItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCardId,
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
                s => s.Item.ItemId == item.ItemId && s.ShoppingCartId == ShoppingCardId);

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

    }
}
