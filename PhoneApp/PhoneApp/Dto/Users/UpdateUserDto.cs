using System.ComponentModel.DataAnnotations;

namespace dadnt.Dto.Users
{
    public class UpdateUserDto : CreateUserDto
    {
        public int UsertId { get; set; }
    }
}
