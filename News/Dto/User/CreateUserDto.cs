using System.ComponentModel.DataAnnotations;

namespace News.Dto.User
{
    public class CreateUserDto
    {
        private string _name;
        private string _username;
        private string _password;
        private string _phonenumber;

        [Required]
        public UserType Type { get; set; }

        [Required]
        public Tus Status { get; set; }

        [Required]
        public string Name
        {
            get => _name;
            set => _name = value?.Trim();
        }

        [Required]
        public string UserName
        {
            get => _username;
            set => _username = value?.Trim();
        }

        [Required]
        public string Password
        {
            get => _password;
            set => _password = value?.Trim();
        }

        [Required]
        public string PhoneNumber
        {
            get => _phonenumber;
            set => _phonenumber = value?.Trim();
        }
    }
}
