namespace PhoneApp.Dtos.Cart
{
    public class UpdateCartDto
    {
        public int CartID { get; set; }
        public int UserID { get; set; }
        public int ProID { get; set; }
        public int OrderID { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
