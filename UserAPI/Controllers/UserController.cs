using Microsoft.AspNetCore.Mvc;
using UserAPI.Models;
using UserAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> Users()
        {
            return await _userService.GetUsers();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User cannot be null");
            }

            var createdUser = await _userService.CreateUser(user);
            return Ok(createdUser);
        }
    }
}
