using MakeYourDiet.Models;
using Microsoft.EntityFrameworkCore;

namespace MakeYourDiet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(GetUsers());
            builder.Entity<Product>().HasData(GetProducts());
        }

        private List<User> GetUsers()
        {
            return Enumerable.Range(1, 100)
                .Select(index => new User
                {
                    UserName = $"User {index}",
                    Password = "password",
                    Id = index,
                    Gender = "male"
                })
                .ToList();
        }

        private List<Product> GetProducts()
        {
            return Enumerable.Range(1, 100)
                .Select(index => new Product
                {
                    Name = $"Product {index}",
                    Fats = index,
                    Carbons = index,
                    Proteins = index,
                    Id = index
                })
                .ToList();
        }
    }
}