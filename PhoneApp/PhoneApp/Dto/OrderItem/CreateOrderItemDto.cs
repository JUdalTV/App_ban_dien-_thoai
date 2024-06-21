using System.ComponentModel.DataAnnotations;

namespace dadnt.Dto.OrderItem
{
    public class CreateOrderItemDto
    {
        [Required]
        public int ProId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "False")]
        public int Quantity { get; set; }
    }
}
