using Microsoft.AspNetCore.Mvc;
using News.Dto.Cart;
using News.Dto.Product;
using News.Service.Abstract;
using System.Collections.Generic;

namespace News.Api.Controllers
{
    [ApiController]
    [Route("api/cart")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost]
        public IActionResult AddCart(AddProductToCartDto input)
        {
            _cartService.AddCart(input);
            return Ok();
        }

        [HttpGet("{cartId}/products")]
        public ActionResult<List<ProductDto>> GetAllProducts(int cartId)
        {
            var products = _cartService.GetAllProduct(cartId);
            return Ok(products);
        }
    }
}
