namespace WebSite1.Models
{
    public class ShoppingCartItem
    {
        public  int ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; }
        public Item Item { get; set; }
        public int Amount { get; set; }
    }
}
