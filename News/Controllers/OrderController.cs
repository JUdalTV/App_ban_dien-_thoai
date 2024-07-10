using Microsoft.AspNetCore.Mvc;
using News.Dto.Order;
using News.Dto.Product;
using News.Service.Abstract;
using System.Collections.Generic;

namespace News.Api.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult AddOrder(AddProductToOrderDto input)
        {
            _orderService.AddOrder(input);
            return Ok();
        }

        [HttpGet("{orderId}/products")]
        public ActionResult<List<ProductDto>> GetAllProductsInOrder(int orderId)
        {
            var products = _orderService.GetAllProductsInOrder(orderId);
            return Ok(products);
        }
    }
}
