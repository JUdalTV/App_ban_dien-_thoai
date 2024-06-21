using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PhoneApp.Dtos.Cart
{
    public class CartDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartID { get; set; }
        public int UserID { get; set; }
        public int ProID { get; set; }
        public int OrderID { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
