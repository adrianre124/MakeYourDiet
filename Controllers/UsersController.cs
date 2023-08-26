using MakeYourDiet.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeYourDiet.Controllers
{
    public class UsersController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return Ok();
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<User>> GetUser(string username)
        {
            return Ok();
        }
    }
}