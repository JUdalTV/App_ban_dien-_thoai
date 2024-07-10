namespace News.Dto.User
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public UserType Type { get; set; }
        public Tus Status { get; set; }
    }
    public enum UserType
    {
        Admin,
        User
    }
    public enum Tus
    {
        activate,
        ban
    }
}
