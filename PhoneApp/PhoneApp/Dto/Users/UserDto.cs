using System.Numerics;

namespace dadnt.Dto.Users
{
    public enum UserType
    {
        Admin,
        RegularUser
    }
    public class UserDto
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public BigInteger PhoneNumber { get; set; }
        public String Password { get; set; }
        public string Status { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public Boolean Type {  get; set; }
        public DateTime DateOfBith { get; set; }
    }
}
