using GraphQlApi.Data;
using GraphQlApi.Models;

namespace GraphQlApi.GraphQl;

public class Query
{
    [UseFiltering]
    [UseSorting]
    public IQueryable<Platform> GetPlatforms(AppDbContext dbContext)
        => dbContext.Platforms;

    [UseFiltering]
    [UseSorting]
    public IQueryable<Command> GetCommands(AppDbContext dbContext)
        => dbContext.Commands;
}
