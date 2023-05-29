using GraphQlApi.Data;
using GraphQlApi.Models;

namespace GraphQlApi.GraphQl.Types
{
    public class CommandType : ObjectType<Command>
    {
        protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
        {
            descriptor.Description("Represents any executable command");
            descriptor
                .Field(c => c.Platform)
                .ResolveWith<CommandTypeResolvers>(r => r.GetPlatform(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the platform to which the command belongs");
        }
    }
}
