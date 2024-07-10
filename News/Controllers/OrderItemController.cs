using Microsoft.AspNetCore.Mvc;
using News.Entity;
using News.Service.Abstract;
using News.Service.Implements;
using System.Collections.Generic;

namespace News.Api.Controllers
{
    [ApiController]
    [Route("api/orderitem")]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemService _orderItemService;

        public OrderItemController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveOrderItem(int id)
        {
            var orderItem = _orderItemService.GetOrderItemById(id);
            _orderItemService.RemoveOrderItem(orderItem);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<OrderItem> GetOrderItemById(int id)
        {
            var orderItem = _orderItemService.GetOrderItemById(id);
            return Ok(orderItem);
        }

        [HttpPost]
        public IActionResult AddOrderItem(OrderItem input)
        {
            _orderItemService.Add(input);
            return Ok();
        }

        [HttpGet("order/{orderId}")]
        public ActionResult<List<OrderItem>> GetOrderItemByOrderId(int orderId)
        {
            var orderItems = _orderItemService.GetOrderItemById(orderId);
            return Ok(orderItems);
        }
    }
}
