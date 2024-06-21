namespace PhoneApp.Dtos.Pay
{
    public class CreatePayDto
    {
        public int PayID { get; set; }
        public int UserID { get; set; }
        public int CartID { get; set; }
        public string MethodPayment { get; set; }
        public DateTime DatePayment { get; set; }
    }
}
