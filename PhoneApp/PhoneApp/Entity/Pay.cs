using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PhoneApp.Entity
{
    public class Pay
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
