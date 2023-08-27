using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeYourDiet.Data;
using MakeYourDiet.Interfaces;
using MakeYourDiet.Models;

namespace MakeYourDiet.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}