using Microsoft.AspNetCore.Mvc;
using SwordandFather.Data;
using SwordandFather.Models;
using SwordandFather.Validators;

namespace SwordandFather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly UserRepository _userRepository;
        readonly CreateUserRequestValidator _validator;

        public UsersController()
        {
            _validator = new CreateUserRequestValidator();
            _userRepository = new UserRepository();
        }

        [HttpPost("register")]
        public ActionResult<int> AddUser(CreateUserRequest createdUser)
        {
            if (!_validator.Validate(createdUser))
                return BadRequest(new { error = "username and password must be valid" });

            var newUser = _userRepository.AddUser(createdUser.Username, createdUser.Password);

            return Created($"api/users/{newUser.Id}", newUser);
        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            var users = _userRepository.GetAll();
            return Ok(users);
        }
    }
}