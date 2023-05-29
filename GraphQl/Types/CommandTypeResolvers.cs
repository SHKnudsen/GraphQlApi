using GraphQlApi.Data;
using GraphQlApi.Models;

namespace GraphQlApi.GraphQl.Types
{
    internal class CommandTypeResolvers
    {
        public Platform GetPlatform([Parent] Command command, AppDbContext context)
            => context.Platforms.FirstOrDefault(x => x.Id == command.PlatformId);
    }
}
