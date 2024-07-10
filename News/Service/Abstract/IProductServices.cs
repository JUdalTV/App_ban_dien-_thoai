using News.Dto.Product;

namespace News.Service.Abstract
{
    public interface IProductServices
    {
        ProductDto CreateProduct(CreateProductDto input, IFormFile image);
        void UpdateProduct(UpdateProductDto input);
        List<ProductDto> GetAll(Dto.Comon.FilterDto input);
        void DeleteProduct(int id);
    }
}
