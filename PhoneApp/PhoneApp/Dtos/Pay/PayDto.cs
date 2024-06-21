using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PhoneApp.Dtos.Pay
{
    public class PayDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PayID { get; set; }
        public int UserID { get; set; }
        public int CartID { get; set; }
        public string MethodPayment { get; set; }
        public DateTime DatePayment { get; set; }
    }
}
