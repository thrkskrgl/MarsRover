using Microsoft.Extensions.DependencyInjection;
using MarsRover.Domain.Persistence;

namespace MarsRover.App
{
    internal class Program
    {
        static void Main()
        {
            // Set up the domain factory
            var domainFactory = Setup();

            // Read input and create aggregate arguments
            var args = domainFactory.GetAggregateArgsProvider().Create([.. ReadLine()]);

            // Create surface based on surface coordinates
            var surface = domainFactory.GetSurfaceProvider().Initialize(args.SurfaceCoordinates);

            // Iterate over initial locations and commands
            foreach ((string initialLocation, string commands) in args.InitialLocationWithCommands)
            {
                // Create current location of the rover
                var currentLocation = domainFactory.GetRoverLocationProvider().Initialize(initialLocation);

                // Create executable commands for the rover
                var executableCommands = domainFactory.GetRoverCommandProvider().Create(commands);

                // Execute each command for the rover and update its location
                foreach (var executableCommand in executableCommands)
                {
                    domainFactory.GetRoverService().ExecuteCommands(executableCommand, currentLocation, surface);
                }

                // Print the final location of the rover
                Console.WriteLine($"{currentLocation.X} {currentLocation.Y} {currentLocation.Direction}");
            }
        }

        // Read input lines from the console
        private static List<string> ReadLine()
        {
            List<string> lines = [];
            string line;
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
            {
                lines.Add(line);
            }
            return lines;
        }

        // Set up the domain factory to create instances of required services
        private static IDomainFactory Setup()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.Register();
            using ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider.GetRequiredService<IDomainFactory>();
        }
    }
}