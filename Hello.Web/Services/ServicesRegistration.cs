using Hello.Web.Services.Implementations;
using Hello.Web.Services.Interfaces;
using static Hello.Web.Models.SD;

namespace Hello.Web.Services
{
    public static class ServicesRegistration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<IProductService, ProductService>();
            ProductAPIBase = configuration["ServiceUrls:ProductAPI"];
            services.AddControllersWithViews();
            return services;
        }
    }
}
