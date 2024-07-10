using Azure.Identity;
using News.DbContexts;
using News.Dto.Comon;
using News.Dto.User;
using News.Entity;
using News.Service.Abstract;

namespace News.Service.Implements
{
    public class UserService : BaseService, IUserService
    {
        public UserService(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public UserDto CreateUser(CreateUserDto input)
        {
            var user = new User
            {
                UserName = input.UserName,
                Name = input.Name,
                Password = input.Password,
                PhoneNumber = input.PhoneNumber,
            };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                Name = user.Name,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber,
            };
        }

        public void UpdateUser(UpdateUserDto input)
        {
            var userFind = FindUserById(input.Id);
            userFind.UserName = input.UserName;
            userFind.Password = input.Password;
            userFind.Name = input.Name;

            _dbContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var userFind = FindUserById(id);
            _dbContext.Users.Remove(userFind);
            _dbContext.SaveChanges();
        }

        public List<UserDto> GetAll(FilterDto input)
        {
            var result = _dbContext.Users.Select(s => new UserDto
            {
                Id = s.Id,
                Name = s.Name,
                UserName = s.UserName,
                PhoneNumber = s.PhoneNumber
            });
            return result.ToList();
        }
    }
}
