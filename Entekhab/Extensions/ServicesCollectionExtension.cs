namespace Entekhab.Endpoints.WebApi.Extensions
{
    public static class ServicesCollectionExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options=> {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "New Swagger",
                    Description = "New Swagger Document",
                    Version = "v1",
                });
            
            });
            services.AddControllers();
            services.AddMvc();

            return services;
        }
    }
}
