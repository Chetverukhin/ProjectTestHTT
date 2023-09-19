using Microsoft.EntityFrameworkCore;
using Test.Server.Data;

namespace Test.Server.Configurations
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContext<ProjectDdContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("Test_DB")));
        }
    }
}
