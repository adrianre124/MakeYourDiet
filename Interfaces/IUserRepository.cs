using MakeYourDiet.DTOs;
using MakeYourDiet.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeYourDiet.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserByUsername(string username);
    }
}