using MakeYourDiet.Data;
using MakeYourDiet.Interfaces;
using MakeYourDiet.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeYourDiet.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var userList = await _userService.GetAllUsers();
            if (userList == null) return NotFound();

            return Ok(userList);
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<User>> GetUserById(int userId)
        {
            var user = await _userService.GetUserById(userId);

            if (user == null) return BadRequest("Couldn't find user");

            return Ok(user);

        }

        [HttpPost]
        public async Task<ActionResult> CreateUser(User user)
        {
            var isUserCreated = await _userService.CreateUser(user);

            if (!isUserCreated) return BadRequest("Couldn't create user");

            return Ok(isUserCreated);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateUser(User user)
        {
            if (user != null)
            {
                var isUserCreated = await _userService.UpdateUser(user);
                
                if (!isUserCreated) return BadRequest("Couldn't update");

                return Ok(isUserCreated);
            }
            
            return BadRequest("Internal Server Error");
        }

        [HttpDelete("{userId}")]
        public async Task<ActionResult> DeleteUser(int userId)
        {
            var isUserCreated = await _userService.DeleteUser(userId);

            if (!isUserCreated) return BadRequest("Couldn't delete user");

            return Ok(isUserCreated);
        }
    }
}