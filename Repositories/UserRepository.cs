using MakeYourDiet.Data;
using MakeYourDiet.Interfaces;
using MakeYourDiet.Models;

namespace MakeYourDiet.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {
            
        }
    }
}