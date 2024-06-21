using dadnt.Dto.Produts;

namespace dadnt.Dto.OrderItem
{
    public class OrderItemDto
    {
        public int ItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public ProductDto Product { get; set; }
    }
}
