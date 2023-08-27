using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeYourDiet.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeYourDiet.Interfaces
{
    public interface IProductService
    {
        Task<bool> CreateProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int productId);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int productId);
    }
}