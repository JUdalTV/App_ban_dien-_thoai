using News.DbContexts;
using News.Dto.Order;
using News.Dto.Product;
using News.Entity;
using News.Service.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace News.Service.Implements
{
    public class OrderService : BaseService, IOrderService
    {
        public OrderService(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public void AddOrder(AddProductToOrderDto input)
        {
            var order = new Order
            {
                UserId = input.Id, // Assuming Id in AddProductToOrderDto represents UserId
                Price = CalculateTotalPrice(input.ProductIdsss) // Corrected property name
            };

            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }

        public List<ProductDto> GetAllProductsInOrder(int orderId)
        {
            var orderItems = _dbContext.OrderItems.Where(oi => oi.OrderId == orderId).ToList();
            var products = new List<ProductDto>();

            foreach (var orderItem in orderItems)
            {
                var product = FindProductById(orderItem.ProductId);
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

        private long CalculateTotalPrice(List<int> productIds)
        {
            // Example implementation: Calculate total price based on productIds
            var totalPrice = 0L;
            foreach (var productId in productIds)
            {
                var product = FindProductById(productId);
                totalPrice += product.Count; // Example: Summing up based on product count or other logic
            }
            return totalPrice;
        }
    }
}
