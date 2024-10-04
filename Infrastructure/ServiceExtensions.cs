using GolrangProductApi.Application.Interfaces;
using GolrangProductApi.Application.Services;
using GolrangProductApi.Domain.Interfaces;
using GolrangProductApi.Infrastructure.Data;
using GolrangProductApi.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GolrangProductApi.Infrastructure
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Configure the DbContext with the connection string from appsettings.json
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
