namespace News.Dto.Cart
{
    public class AddProductToCartDto
    {
        public int Id { get; set; }
        public List<int> ProductIds { get; set; }
    }
}
