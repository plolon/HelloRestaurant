namespace Hello.Services.ProductAPI.Profiles
{
    public static class ProfilesRegistration
    {
        public static IServiceCollection RegisterProfiles(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
