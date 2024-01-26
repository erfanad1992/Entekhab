using Entekhab.Domain;
using Entekhab.Infrastructure.EfPersistance.PersonInfos;
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
                options.UseSqlServer("Server=.;Database=SejatDbTest;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true",
                    x => x.MigrationsHistoryTable("__EFMigrationsHistory"));
 
            });

            services.AddScoped<DbContext>((sp) => sp.GetRequiredService<EntekhabDbContext>());
            services.AddTransient<IPersonInfoRepository, PersonInfoRepository>();


        }
    }

}
