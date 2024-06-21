using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace dadnt.Dto.Users
{
    public class CreateUserDto
    {
        private string _userName;
        private string _password;
        private string _status;
        private string _address;
        private string _email;

        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên không được bỏ trống")]
        public string UserName
        {
            get => _userName;
            set => _userName = value?.Trim();
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Mật khẩu không được bỏ trống")]
        public string Password
        {
            get => _password;
            set => _password = value?.Trim();
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Trạng thái không được bỏ trống")]
        public string Status
        {
            get => _status;
            set => _status = value?.Trim();
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Địa chỉ không được bỏ trống")]
        public string Address
        {
            get => _address;
            set => _address = value?.Trim();
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email không được bỏ trống")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
        public string Email
        {
            get => _email;
            set => _email = value?.Trim();
        }

        [Required(ErrorMessage = "Số điện thoại không được bỏ trống")]
        public BigInteger PhoneNumber { get; set; }

        [Required(ErrorMessage = "Loại không được bỏ trống")]
        public UserType Type { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được bỏ trống")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}
