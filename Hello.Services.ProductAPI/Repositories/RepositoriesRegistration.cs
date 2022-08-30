using Hello.Services.ProductAPI.Repositories.Implementations;
using Hello.Services.ProductAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hello.Services.ProductAPI.Repositories
{
    public static class RepositoriesRegistration
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}
