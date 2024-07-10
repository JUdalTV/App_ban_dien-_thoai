using News.DbContexts;
using News.Entity;
using News.Service.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace News.Service.Implements
{
    public class CartItemService : BaseService, ICartItemService
    {
        public CartItemService(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public void AddCartItem(CartItem input)
        {
            _dbContext.CartItems.Add(input);
            _dbContext.SaveChanges();
        }

        public void RemoveCartItem(int cartItemId)
        {
            var cartItem = FindCartItemById(cartItemId);
            _dbContext.CartItems.Remove(cartItem);
            _dbContext.SaveChanges();
        }

        public CartItem GetCartItemById(int cartItemId)
        {
            return FindCartItemById(cartItemId);
        }

        public List<CartItem> GetCartItemsByCartId(int cartId)
        {
            return _dbContext.CartItems.Where(ci => ci.CartId == cartId).ToList();
        }
    }
}
