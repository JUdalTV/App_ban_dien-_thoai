namespace News.Dto.Pay
{
    public class PayDto
    {
        public int Id { get; set; }
        public Method MethodPayment { get; set; }
        public DateTime DatePayment { get; set; }
    }
    public enum Method
    {
        Online,
        Direct
    }
}
