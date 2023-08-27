using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeYourDiet.Data;
using MakeYourDiet.Interfaces;
using MakeYourDiet.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MakeYourDiet.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllersWithViews();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddDbContext<DataContext>(options => 
                options.UseSqlite(config.GetConnectionString("DefaultConnection")));
            services.AddCors();

            return services;
        }
    }
}