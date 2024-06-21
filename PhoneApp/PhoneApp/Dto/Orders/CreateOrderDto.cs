using dadnt.Dto.OrderItem;
using System.ComponentModel.DataAnnotations;

namespace dadnt.Dto.Orders
{
    public class CreateOrderDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "False")]
        public DateTime OrderDate { get; set; }

        public List<CreateOrderItemDto> OrderItems { get; set; }
    }
}
