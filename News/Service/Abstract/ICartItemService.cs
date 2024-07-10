using News.Dto.Product;
using News.Entity;

namespace News.Service.Abstract
{
    public interface ICartItemService
    {
        void AddCartItem(CartItem input);
        void RemoveCartItem(int cartItemId);
        CartItem GetCartItemById(int cartItemId);
        List<CartItem> GetCartItemsByCartId(int cartId);
    }
}
