using GraphQlApi.Data;
using GraphQlApi.GraphQl.Inputs;
using GraphQlApi.GraphQl.Payloads;
using GraphQlApi.Models;

namespace GraphQlApi.GraphQl
{
    public class Mutation
    {
        public async Task<AddPlatformPayload> AddPlatformAsync(
            AddPlatformInput input,
            AppDbContext dbContext)
        {
            var newPlatform = new Platform
            {
                Name = input.Name,
            };

            dbContext.Platforms.Add(newPlatform);
            await dbContext.SaveChangesAsync();
            return new AddPlatformPayload(newPlatform);
        }

        public async Task<AddCommandPayload> AddCommand(
            AddCommandInput input,
            AppDbContext dbContext)
        {
            var newCommand = new Command
            {
                HowTo = input.HowTo,
                CommandLine = input.CommandLine,
                PlatformId = input.PlatformId,
            };

            dbContext.Commands.Add(newCommand);
            await dbContext.SaveChangesAsync();
            return new(newCommand);
        }
    }
}
