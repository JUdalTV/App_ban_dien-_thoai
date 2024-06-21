using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PhoneApp.Entity
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartID { get; set; }
        public int UserID { get; set; }
        public int ProID {  get; set; }
        public int OrderID { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
