using System.ComponentModel.DataAnnotations;

namespace News.Dto.Pay
{
    public class CreatePayDto
    {
        [Required]
        public Method MethodPayment { get; set; }
        public DateTime DatePayment { get; set; }
    }
}
