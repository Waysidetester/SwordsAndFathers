using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwordandFather.Models;

namespace SwordandFather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        static List<User> _users = new List<User>();

        [HttpPost("register")]
        public ActionResult<int> AddUser(User newUser)
        {
            newUser.Id = _users.Count + 1;

            _users.Add(newUser);

            return Created($"api/users/{newUser.Id}", newUser);
        }
    }
}