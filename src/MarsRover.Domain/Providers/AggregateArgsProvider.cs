using MarsRover.Domain.Enums;
using MarsRover.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Providers
{
    public class AggregateArgsProvider : IAggregateArgsProvider
    {
        public AggregateArgs Create(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);

            if (args.Length < 5)
            {
                throw new ArgumentException("Input must be at least 5 lines");
            }

            var result = new AggregateArgs
            {
                SurfaceCoordinates = args[0]
            };

            foreach (var tuple in ParseInput(args))
            {
                result.InitialLocationWithCommands.Add(tuple);
            }

            return result;
        }

        static IEnumerable<(string, string)> ParseInput(string[] parts)
        {
            for (int i = 1; i < parts.Length; i += 2)
            {
                yield return (parts[i], parts[i + 1]);
            }
        }
    }
}
