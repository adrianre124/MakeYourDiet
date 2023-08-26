using MakeYourDiet.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeYourDiet.Interfaces
{
    public interface IUserRepository
    {
        Task<ActionResult<User>> GetUserByIdAsync(int id);
        Task<ActionResult<IEnumerable<User>>> GetUsersAsync();
        void Update(User user);
    }
}