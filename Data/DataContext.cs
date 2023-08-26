using MakeYourDiet.Models;
using Microsoft.EntityFrameworkCore;

namespace MakeYourDiet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        DbSet<User> Users { get; set; }
    }
}