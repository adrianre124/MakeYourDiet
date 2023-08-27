using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeYourDiet.Interfaces;
using MakeYourDiet.Models;

namespace MakeYourDiet.Services
{
    public class UserService : IUserService
    {
        public IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateUser(User user)
        {
            if (user != null)
            {
                await _unitOfWork.UserRepository.Add(user);

                await _unitOfWork.Complete();
            }

            return false;
        }

        public async Task<bool> DeleteUser(int userId)
        {
            if (userId > 0)
            {
                var user = await _unitOfWork.UserRepository.GetById(userId);
                if (user != null)
                {
                    _unitOfWork.UserRepository.Remove(user);
                    await _unitOfWork.Complete();
                }
            }

            return false;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var userList = await _unitOfWork.UserRepository.GetAll();
            return userList;
        }

        public async Task<User> GetUserById(int userId)
        {
            if (userId > 0)
            {
                var user = await _unitOfWork.UserRepository.GetById(userId);
                if (user != null)
                {
                    return user;
                }
            }
            
            return null;
        }

        public async Task<bool> UpdateUser(User user)
        {
            if (user != null)
            {
                var getUser = await _unitOfWork.UserRepository.GetById(user.Id);
                if (getUser != null)
                {
                    getUser.UserName = user.UserName;
                    getUser.Password = user.Password;
                    getUser.Created = user.Created;
                    getUser.Gender = user.Gender;
                    getUser.LastActive = user.LastActive;

                    _unitOfWork.UserRepository.Update(getUser);
                }
            }

            return false;
        }
    }
}