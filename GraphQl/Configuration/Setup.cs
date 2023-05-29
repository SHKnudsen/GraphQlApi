using GraphQlApi.Data;
using GraphQlApi.GraphQl.Types;
using HotChocolate.Execution.Configuration;

namespace GraphQlApi.GraphQl.Configuration;

internal static class Setup
{
    public static IServiceCollection RegisterGraphQl(
        this IServiceCollection services)
    {
        services
            .AddGraphQLServer()
            .AddGraphQlTypes()
            .AddFiltering()
            .AddSorting()
            .RegisterDbContext<AppDbContext>(DbContextKind.Pooled)
            .AddDiagnosticEventListener<ErrorLoggingDiagnosticsEventListener>();
        return services;
    }

    private static IRequestExecutorBuilder AddGraphQlTypes(this IRequestExecutorBuilder requestExecutor)
        => requestExecutor
            .AddQueryType<Query>()
            .AddMutationType<Mutation>()
            .AddType<PlatformType>()
            .AddType<CommandType>();
}
