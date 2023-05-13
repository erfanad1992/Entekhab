using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Entekhab.Infrastructure.EfPersistance.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddPersistenceEntityFrameworkServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<EntekhabDbContext>((serviceProvider, options) =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServerConnectionString"),
                    x => x.MigrationsHistoryTable("__EFMigrationsHistory"));
 
            });

            services.AddScoped<DbContext>((sp) => sp.GetRequiredService<EntekhabDbContext>()); 


        }
    }

}
