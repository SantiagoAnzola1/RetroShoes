using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using UserBusiness;
using UserDomain;
namespace UserAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private IConfiguration Configuration;

        public UserController(ILogger<UserController> logger, IConfiguration config)
        {
            _logger = logger;
            Configuration = config;
        }

        

       
        //[HttpGet("GetUserById")]
        //public User GetUserById(String Userid)
        //{
        //    UserB userBusiness = new UserB();
        //    User user = new User();
        //    user = userBusiness.getUser();
        //    UserB userBusiness = new UserB();
        //    userBusiness.getUsersByid(useID, Configuration.GetConnectionString("DefaultConnection"));
        //    return userBusiness.getUsersByid(Configuration.GetConnectionString("DefaultConnection"));

        //}

        [HttpGet("GetUsersDB")]
        public IEnumerable<User> GetUsersDB()
        {
            UserB userBusiness = new UserB();
            return userBusiness.getUsersDB(Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpGet("GetUserById/{id:long}")]
        public User GetUser(long id)
        {
            UserB userBusiness = new UserB();
            return userBusiness.getUser(id, Configuration.GetConnectionString("DefaultConnection"));

        }

        [HttpGet("IsRegister/{id:long}")]
        public Boolean IsRegister(long id)
        {
            UserB userBusiness = new UserB();
            return userBusiness.isRegister(id, Configuration.GetConnectionString("DefaultConnection"));
        }
        [HttpPost("CreateUser")]
        public IEnumerable<User> CreateUserDB(User user)
        {
            UserB userBusiness = new UserB();
            userBusiness.createUser(user, Configuration.GetConnectionString("DefaultConnection"));
            return userBusiness.getUsersDB(Configuration.GetConnectionString("DefaultConnection"));

        }
        [HttpPost("IsLogged")]
        public Boolean IsLogged(UserLog user)
        {
            UserB userBusiness = new UserB();
            return userBusiness.isLogged(user, Configuration.GetConnectionString("DefaultConnection"));
        }
        [HttpPut("UpdateUser")]
        public IEnumerable<User> UpdateUserDB(User user)
        {
            UserB userBusiness = new UserB();
            userBusiness.updateUser(user, Configuration.GetConnectionString("DefaultConnection"));
            return userBusiness.getUsersDB(Configuration.GetConnectionString("DefaultConnection"));

        }
       
        [HttpDelete("DeleteUser/{id:long}")]
        public IEnumerable<User> DeleteUserDB(long id)
        {
            UserB userBusiness = new UserB();
            userBusiness.deleteUser(id, Configuration.GetConnectionString("DefaultConnection"));
            return userBusiness.getUsersDB(Configuration.GetConnectionString("DefaultConnection"));

        }
    }
}