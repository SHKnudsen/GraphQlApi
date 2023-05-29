using GraphQlApi.Data;
using GraphQlApi.Models;

namespace GraphQlApi.GraphQl.Types
{
    public class PlatformType : ObjectType<Platform>
    {
        protected override void Configure(IObjectTypeDescriptor<Platform> descriptor)
        {
            descriptor.Description("Any platform that has a command line");

            descriptor
                .Field(p => p.Commands)
                .ResolveWith<PlatformTypeResolvers>(x => x.GetCommands(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("All available commands for this platform");

        }
    }
}
