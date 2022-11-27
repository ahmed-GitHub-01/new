using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extinsions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(options =>
                     {
                         options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
                     });
            services.AddScoped<ITokenService, TokenService>();
            return services;
        }
    }
}