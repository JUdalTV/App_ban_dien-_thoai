using News.DbContexts;
using News.Dto.Cart;
using News.Dto.Product;
using News.Entity;
using News.Service.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace News.Service.Implements
{
    public class CartService : BaseService, ICartService
    {
        public CartService(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public void AddCart(AddProductToCartDto input)
        {
            var cart = new Cart
            {
                UserId = input.Id, // Assuming Id in AddProductToCartDto represents UserId
                CartItemId = input.ProductIds.FirstOrDefault(), // Example: Taking the first productId for CartItemId
                Quantity = input.ProductIds.Count // Quantity as number of products added
            };

            _dbContext.Carts.Add(cart);
            _dbContext.SaveChanges();
        }

        public List<ProductDto> GetAllProduct(int CartId)
        {
            var cart = FindCartById(CartId);
            var cartItems = _dbContext.CartItems.Where(ci => ci.CartId == CartId).ToList();
            var products = new List<ProductDto>();

            foreach (var cartItem in cartItems)
            {
                var product = FindProductById(cartItem.ProductId);
                products.Add(new ProductDto
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    Description = product.Description,
                    Count = product.Count,
                    Brand = product.Brand
                });
            }

            return products;
        }
    }
}
