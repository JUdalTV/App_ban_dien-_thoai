using News.Dto.Cart;
using News.Dto.Product;

namespace News.Service.Abstract
{
    public interface ICartService
    {
        void AddCart(AddProductToCartDto input);
        List<ProductDto> GetAllProduct(int CartId);
    }
}
