using News.Dto.Order;
using News.Dto.Product;
using News.Entity;

namespace News.Service.Abstract
{
    public interface IOrderService
    {
        void AddOrder(AddProductToOrderDto input);
        List<ProductDto> GetAllProductsInOrder(int orderId);
    }
}
