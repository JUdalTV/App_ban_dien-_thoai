using Microsoft.Identity.Client;

namespace News.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public int CartItemId { get; set; }
        public int OrderItemId { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Specifications { get; set; }
        public string Price { get; set; }
        public string ImagePath { get; set; }
        public bool IsDeleted { get; internal set; }
    }
}
