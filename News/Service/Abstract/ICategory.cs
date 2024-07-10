using News.Dto.Product;
using News.ProductCategory;

namespace News.Service.Abstract
{
    public interface ICategory
    {
        void AddCategory(ProductCategoryDto input);
        List<ProductDto> GetAllProduct(ProductCategoryDto input);
    }
}
