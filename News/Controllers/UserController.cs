using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.DbContexts;
using News.Dto.Comon;
using News.Dto.User;
using News.Entity;
using News.Service.Abstract;
using News.Service.Implements;
using News.Dto;


namespace News.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [Obsolete("bỏ danh sách này đi")]
        private static List<User> _users = new List<User>();
        [Obsolete("bỏ id này đi")]
        private static int _id = 0;
        private readonly IUserService _userService;
        private readonly ApplicationDbContext _dbContext;

        public UserController(IUserService userService, ApplicationDbContext dbContext)
        {
            _userService = userService;
            _dbContext = dbContext;
        }
        [HttpPost("create")]
        public IActionResult CreateUser(CreateUserDto input) //tại sao request body lại binding vào hàm này được ?
        {
            //if (string.IsNullOrEmpty(input.Name))
            //{
            //    return BadRequest("Tên không hợp lệ"); //http status 400
            //}
            //var student = new Student
            //{
            //    Id = ++_id,
            //    Name = input.Name,
            //    StudentCode = input.StudentCode,
            //    DateOfBirth = input.DateOfBirth,
            //    IsDeleted = false
            //};

            //_students.Add(student);
            //các hàm đều trả về các đối tượng implement interface IActionResult
            var student = _userService.CreateUser(input);
            return Ok(student); //http status code 200
        }

        [HttpGet("get-all")]
        public IActionResult GetUser([FromQuery] FilterDto input)
        {
            try
            {
                return Ok(_userService.GetAll(input));
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Message = ex.Message
                });
            }
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetById(int id)
        {
            //sử dụng hàm firstOrDefault
            var userFind = _users.FirstOrDefault(s => s.Id == id && !s.IsDeleted);
            if (userFind == null)
            {
                return BadRequest(new { message = $"Không tìm thấy sinh viên có id {id}" });
            }
            return Ok(new UserDto
            {
                Id = userFind.Id,
                Name = userFind.Name,
                UserName = userFind.UserName,
                PhoneNumber = userFind.PhoneNumber,
            });
        }

        [HttpPut("update")]
        public IActionResult UpdateUser(UpdateUserDto input)
        {
            try
            {
                _userService.UpdateUser(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Message = ex.Message
                });
            }
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteUser(int id)
        {
            //var studentFind = _students.Find(s => s.Id == id && !s.IsDeleted);
            //if (studentFind == null)
            //{
            //    return BadRequest(new ApiResponse { Message = $"Không tìm thấy sinh viên có id {id}" });
            //}
            //studentFind.IsDeleted = true;
            ////_students.Remove(studentFind);
            ///
            _userService.DeleteUser(id);
            return Ok();
        }

    }
}
