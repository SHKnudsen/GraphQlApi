using GraphQL.Server.Ui.Voyager;
using GraphQlApi.Data.Configuration;
using GraphQlApi.GraphQl.Configuration;

var builder = WebApplication.CreateBuilder(args);
RegisterServices(builder);

var app = builder.Build();
app.MapGraphQL();
app.UseGraphQLVoyager(options: new VoyagerOptions());

app.Run();

void RegisterServices(WebApplicationBuilder builder)
{
    builder.Services
        .RegisterGraphQl()
        .RegisterDbContext(builder.Configuration);
}

