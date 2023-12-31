using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeYourDiet.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IProductRepository ProductRepository { get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}