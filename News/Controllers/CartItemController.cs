using Microsoft.AspNetCore.Mvc;
using News.Entity;
using News.Service.Abstract;
using System.Collections.Generic;

namespace News.Api.Controllers
{
    [ApiController]
    [Route("api/cartitem")]
    public class CartItemController : ControllerBase
    {
        private readonly ICartItemService _cartItemService;

        public CartItemController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        [HttpPost]
        public IActionResult AddCartItem(CartItem input)
        {
            _cartItemService.AddCartItem(input);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveCartItem(int id)
        {
            _cartItemService.RemoveCartItem(id);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<CartItem> GetCartItemById(int id)
        {
            var cartItem = _cartItemService.GetCartItemById(id);
            return Ok(cartItem);
        }

        [HttpGet("cart/{cartId}")]
        public ActionResult<List<CartItem>> GetCartItemsByCartId(int cartId)
        {
            var cartItems = _cartItemService.GetCartItemsByCartId(cartId);
            return Ok(cartItems);
        }
    }
}
