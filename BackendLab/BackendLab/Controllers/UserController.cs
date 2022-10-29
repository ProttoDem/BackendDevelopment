using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendLab.Controllers
{
    [Route("[controller]/[action]/{id?}")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public ActionResult<User> CreateUser([FromBody] User user)
        {
            UserRepository userRepository = UserRepository.GetInstance();
            userRepository.AddNewUser(user);
            return Ok($"Added new user: {user.Name}");
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            UserRepository userRepository = UserRepository.GetInstance();            
            return Ok(userRepository.Users());
        }

        [HttpGet]
        public ActionResult<User> GetUser([FromRoute]int id)
        {
            UserRepository userRepository = UserRepository.GetInstance();
            return Ok(userRepository.User(id));
        }
    }
}
