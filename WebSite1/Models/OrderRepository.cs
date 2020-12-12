using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite1.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext , ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();
            foreach ( var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new Order
                {
                    Amount = shoppingCartItem.Amount,
                    Price = (decimal)shoppingCartItem.Item.Price,
                    ItemId = shoppingCartItem.Item.ItemId,
                    OrderId = order.OrderId
                };
                _appDbContext.orderDetails.Add(orderDetail);
            }
            _appDbContext.SaveChanges();
        }        
    }
}
