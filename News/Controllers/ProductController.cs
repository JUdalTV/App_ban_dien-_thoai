using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.DbContexts;
using News.Dto.Comon;
using News.Dto.Product;
using News.Dto.User;
using News.Entity;
using News.Service.Abstract;
using News.Service.Implements;

namespace News.Controllers
{
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        [Obsolete("bỏ danh sách này đi")]
        private static List<Product> _products = new List<Product>();
        [Obsolete("bỏ id này đi")]
        private static int _id = 0;
        private readonly IProductServices _productService;
        private readonly ApplicationDbContext _dbContext;

        public ProductController(IProductServices productService, ApplicationDbContext dbContext)
        {
            _productService = productService;
            _dbContext = dbContext;
        }

        [HttpPost("create")]
        public IActionResult CreateProduct([FromForm] CreateProductDto input, IFormFile image)
        {
            var product = _productService.CreateProduct(input, image);
            return Ok(product);
        }

        [HttpGet("get-all")]
        public IActionResult GetProduct([FromQuery] FilterDto input)
        {
            try
            {
                return Ok(_productService.GetAll(input));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Message = ex.Message
                });
            }
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetById(int id)
        {
            //sử dụng hàm firstOrDefault
            var productFind = _products.FirstOrDefault(s => s.Id == id && !s.IsDeleted);
            if (productFind == null)
            {
                return BadRequest(new { message = $"Không tìm thấy sinh viên có id {id}" });
            }
            return Ok(new ProductDto
            {
                Id = productFind.Id,
                ProductName = productFind.ProductName,
                Count = productFind.Count,
                Price = productFind.Price,
                Specifications = productFind.Specifications,
                Description = productFind.Description,
                Brand = productFind.Brand,
            });
        }

        [HttpPut("update")]
        public IActionResult UpdateProduct(UpdateProductDto input)
        {
            try
            {
                _productService.UpdateProduct(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Message = ex.Message
                });
            }
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            //var studentFind = _students.Find(s => s.Id == id && !s.IsDeleted);
            //if (studentFind == null)
            //{
            //    return BadRequest(new ApiResponse { Message = $"Không tìm thấy sinh viên có id {id}" });
            //}
            //studentFind.IsDeleted = true;
            ////_students.Remove(studentFind);
            ///
            _productService.DeleteProduct(id);
            return Ok();
        }

    }
}
