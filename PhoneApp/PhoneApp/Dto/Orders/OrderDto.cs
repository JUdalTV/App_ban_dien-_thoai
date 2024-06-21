using dadnt.Dto.OrderItem;

namespace dadnt.Dto.Orders
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
    }
}
