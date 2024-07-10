using News.DbContexts;
using News.Entity;
using News.Exceptions;

namespace News.Service.Implements
{
    public class BaseService
    {
        protected readonly ApplicationDbContext _dbContext;
        public BaseService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        protected Product FindProductById (int productId)
        {
            var productFind = _dbContext.Products.FirstOrDefault(s => s.Id == productId && !s.IsDeleted);
            if (productFind == null)
            {
                throw new UserFriendlyException ("khong tim thay");
            }
            return productFind;
        }

        protected User FindUserById(int userId)
        {
            var userFind = _dbContext.Users.FirstOrDefault(s => s.Id == userId && !s.IsDeleted);
            if (userFind == null)
            {
                throw new UserFriendlyException("Khong tim thay");
            }
            return userFind;
        }
        protected Cart FindCartById(int cartId)
        {
            var cartFind = _dbContext.Carts.FirstOrDefault(c => c.Id == cartId);
            if (cartFind == null)
            {
                throw new UserFriendlyException($"Cart with Id {cartId} not found.");
            }
            return cartFind;
        }
        protected CartItem FindCartItemById(int cartItemId)
        {
            var cartItemFind = _dbContext.CartItems.FirstOrDefault(ci => ci.Id == cartItemId);
            if (cartItemFind == null)
            {
                throw new UserFriendlyException($"CartItem with Id {cartItemId} not found.");
            }
            return cartItemFind;
        }

        protected Order FindOrderById(int orderId)
        {
            var orderFind = _dbContext.Orders.FirstOrDefault(o => o.Id == orderId);
            if (orderFind == null)
            {
                throw new UserFriendlyException($"Order with Id {orderId} not found.");
            }
            return orderFind;
        }

        protected OrderItem FindOrderItemById(int orderItemId)
        {
            var orderItemFind = _dbContext.OrderItems.FirstOrDefault(oi => oi.Id == orderItemId);
            if (orderItemFind == null)
            {
                throw new UserFriendlyException($"OrderItem with Id {orderItemId} not found.");
            }
            return orderItemFind;
        }
    }
}
