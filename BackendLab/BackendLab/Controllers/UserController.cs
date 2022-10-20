using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendLab.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public ActionResult<User> CreateUser(User user)
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
    }
}
