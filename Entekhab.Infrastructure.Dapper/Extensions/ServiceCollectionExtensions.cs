using Entekhab.Domain;
using Entekhab.Infrastructure.EfPersistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace Entekhab.Infrastructure.Dapper.Extensions
{
    public static class DapperServiceCollectionExtensions
    {
        public static void AddDapperServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<EntekhabQueriesDbContext>((serviceProvider, options) =>
            {
                options.UseSqlServer("Server=.;Database=SejatDbTest;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true",
                    x => x.MigrationsHistoryTable("__EFMigrationsHistory"));

            });

            services.AddScoped<DbContext>((sp) => sp.GetRequiredService<EntekhabQueriesDbContext>());
            services.AddTransient<IDbConnection>(provider =>
            {

                string connectionString = configuration.GetConnectionString("SqlServerConnectionString");
                return new SqlConnection(connectionString);
            });
            services.AddTransient<IPersonInfoReadRepository, PersonInfoReadRepository>();


        }
    }
}
