using News.Dto.User;

namespace News.Service.Abstract
{
    public interface IUserService
    {
        UserDto CreateUser(CreateUserDto input);
        void UpdateUser(UpdateUserDto input);
        List<UserDto> GetAll(Dto.Comon.FilterDto input);
        void DeleteUser(int id);
    }
}
