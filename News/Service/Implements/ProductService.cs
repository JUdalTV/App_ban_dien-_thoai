using News.DbContexts;
using News.Dto.Comon;
using News.Dto.Product;
using News.Entity;
using News.Service.Abstract;

namespace News.Service.Implements
{
    public class ProductService : BaseService, IProductServices
    {
        public ProductService(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
        public ProductDto CreateProduct(CreateProductDto input, IFormFile image)
        {
            var product = new Product
            {
                ProductName = input.ProductName,
                Description = input.Description,
                Specifications = input.Specifications,
                Count = input.Count,
                Price = input.Price,
                Brand = input.Brand,
            };

            // Xử lý lưu file ảnh
            if (image != null && image.Length > 0)
            {
                var imagePath = Path.Combine("wwwroot/images", image.FileName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }
                product.ImagePath = imagePath;
            }

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();

            return new ProductDto
            {
                Id = product.Id,
                ProductName = product.ProductName,
                Description = product.Description,
                Specifications= product.Specifications,
                Count = product.Count,
                Price = product.Price,
                Brand = product.Brand,
            };
        }

        public void UpdateProduct(UpdateProductDto input)
        {
            var productFind = FindProductById(input.Id);
            productFind.ProductName = input.ProductName;
            productFind.Description = input.Description;
            productFind.Specifications = input.Specifications;
            productFind.Count = input.Count;
            productFind.Price = input.Price;
            productFind.Brand = input.Brand;

            _dbContext.SaveChanges();
        }

        public List<ProductDto> GetAll()
        {
            var result = _dbContext.Products.Select(s => new ProductDto
            {
                Id = s.Id,
                ProductName = s.ProductName,
                Description = s.Description,
                Specifications = s.Specifications,
                Count = s.Count,
                Price = s.Price,
                Brand = s.Brand,
            });
            return result.ToList();
        }

        public void DeleteProduct(int id)
        {
            var productFind = FindProductById(id);
            _dbContext.Products.Remove(productFind);
            _dbContext.SaveChanges();
        }

        public List<ProductDto> GetAll(FilterDto input)
        {
            var query = _dbContext.Products.AsQueryable();

            // Lọc theo từ khóa nếu có
            if (!string.IsNullOrEmpty(input.Keyword))
            {
                query = query.Where(p => p.ProductName.Contains(input.Keyword) ||
                                         p.Description.Contains(input.Keyword) ||
                                         p.Brand.Contains(input.Keyword));
            }

            // Phân trang
            var totalItems = query.Count();
            var products = query.Skip(input.Skip())
                                .Take(input.PageSize)
                                .Select(p => new ProductDto
                                {
                                    Id = p.Id,
                                    ProductName = p.ProductName,
                                    Description = p.Description,
                                    Specifications = p.Specifications,
                                    Count = p.Count,
                                    Price = p.Price,
                                    Brand = p.Brand,
                                })
                                .ToList();

            return products;
        }

    }
}
