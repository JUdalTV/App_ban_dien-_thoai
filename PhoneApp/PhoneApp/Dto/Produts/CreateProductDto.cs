using System.ComponentModel.DataAnnotations;

namespace dadnt.Dto.Produts
{
    public class CreateProductDto
    {
        private string _proName;
        private decimal _price;
        private int _count;
        private string _description;
        private string _brand;
        private string _image;

        [Required(AllowEmptyStrings = false, ErrorMessage = "False")]
        public string ProName
        {
            get => _proName; set => _proName = value;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "False")]
        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "False")]
        public int Count
        {
            get => _count;
            set => _count = value;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "False")]
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "False")]
        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "False")]
        public string Image
        {
            get => _image;
            set => _image = value?.Trim();
        }

        public int CateId { get; set; }
    }
}
