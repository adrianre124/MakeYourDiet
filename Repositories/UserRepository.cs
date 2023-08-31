using MakeYourDiet.Data;
using MakeYourDiet.DTOs;
using MakeYourDiet.Interfaces;
using MakeYourDiet.Models;
using Microsoft.EntityFrameworkCore;

namespace MakeYourDiet.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);
        }
    }
}