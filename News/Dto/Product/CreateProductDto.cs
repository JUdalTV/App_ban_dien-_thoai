using System.ComponentModel.DataAnnotations;

namespace News.Dto.Product
{
    public class CreateProductDto
    {
        private string _productname;
        private string _description;
        private int _count;
        private string _brand;
        private string _price;
        private string _specifications;

        [Required]
        public string ProductName
        {
            get => _productname; 
            set => _productname = value?.Trim();
        }

        public int Count
        {
            get => _count;
            set
            {
                if (value >=0)
                {
                    _count = value;
                }
                else
                {
                    throw new ArgumentException("Count must be non-negative");
                }
            }
        }
        [Required]
        public string Price
        {
            get => _price;
            set => _price = value?.Trim();
        }
        [Required]
        public string Specifications
        {
            get => _specifications;
            set => _specifications = value?.Trim();
        }

        [Required]
        public string Description
        {
            get => _description;
            set => _description = value?.Trim();
        }

        [Required]
        public string Brand
        {
            get => _brand;
            set => _brand = value?.Trim();
        }

        [Required]
        public IFormFile Image { get; set; }
    }
}
