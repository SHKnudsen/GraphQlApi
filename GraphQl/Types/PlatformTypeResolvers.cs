using GraphQlApi.Data;
using GraphQlApi.Models;

namespace GraphQlApi.GraphQl.Types
{
    internal class PlatformTypeResolvers
    {
        public IQueryable<Command> GetCommands([Parent]Platform platform, AppDbContext appDbContext)
            => appDbContext.Commands.Where(c => c.PlatformId == platform.Id);
    }
}
