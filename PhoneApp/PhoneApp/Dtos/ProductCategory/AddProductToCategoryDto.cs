using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PhoneApp.Dtos.ProductCategory
{
    public class AddProductToCategoryDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CateID { get; set; }
        public string Name { get; set; }
    }

}
