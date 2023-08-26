using MakeYourDiet.Data;
using MakeYourDiet.Interfaces;
using MakeYourDiet.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeYourDiet.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public Task<ActionResult<User>> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<User>>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}