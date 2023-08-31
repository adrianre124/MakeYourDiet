using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeYourDiet.Data;
using MakeYourDiet.Interfaces;
using MakeYourDiet.Repositories;
using MakeYourDiet.Services;
using Microsoft.EntityFrameworkCore;

namespace MakeYourDiet.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllersWithViews();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddDbContext<DataContext>(options => 
                options.UseSqlite(config.GetConnectionString("DefaultConnection")));
            services.AddCors();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}