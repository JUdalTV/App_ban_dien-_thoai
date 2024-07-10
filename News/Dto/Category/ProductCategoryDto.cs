namespace News.ProductCategory
{
    public class ProductCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<int> ProductIdss { get; set; }
    }
}

