using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PhoneApp.Dtos.CartItem
{
    public class AddItemToCardDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }
        public List<int> ProID { get; set; }
        public int Quantity { get; set; }
    }
}
