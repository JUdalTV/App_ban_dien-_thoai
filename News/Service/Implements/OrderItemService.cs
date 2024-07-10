using News.DbContexts;
using News.Entity;
using News.Exceptions;
using News.Service.Abstract;
using System.Linq;

namespace News.Service.Implements
{
    public class OrderItemService : BaseService, IOrderItemService
    {
        public OrderItemService(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public void RemoveOrderItem(OrderItem input)
        {
            var orderItem = GetOrderItemById(input.Id);
            if (orderItem != null)
            {
                _dbContext.OrderItems.Remove(orderItem);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new UserFriendlyException("Order item not found.");
            }
        }

        public OrderItem GetOrderItemById(int orderItemId)
        {
            return _dbContext.OrderItems.FirstOrDefault(oi => oi.Id == orderItemId);
        }

        public void Add(OrderItem item)
        {
            _dbContext.OrderItems.Add(item);
            _dbContext.SaveChanges();
        }

        public List<OrderItem> GetAllOrders(int orderId)
        {
            return _dbContext.OrderItems.Where(ci => ci.OrderId == orderId).ToList();
        }
    }
}
