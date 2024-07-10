using News.Entity;

namespace News.Service.Abstract
{
    public interface IOrderItemService
    {
        void Add(OrderItem item);
        void RemoveOrderItem(OrderItem input);
        OrderItem GetOrderItemById(int orderItemId);
        List<OrderItem> GetAllOrders(int orderId);
    }
}
