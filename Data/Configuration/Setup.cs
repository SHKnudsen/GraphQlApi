using Microsoft.EntityFrameworkCore;

namespace GraphQlApi.Data.Configuration;

internal static class Setup
{
    public static IServiceCollection RegisterDbContext(
        this IServiceCollection services,
        ConfigurationManager configuration)
        => services
        .AddPooledDbContextFactory<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("SqlDb")));
}
