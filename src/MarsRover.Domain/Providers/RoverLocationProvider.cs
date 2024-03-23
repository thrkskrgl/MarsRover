using MarsRover.Domain.Enums;
using MarsRover.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Providers
{
    public class RoverLocationProvider : ProviderBase<Rover>, IRoverLocationProvider
    {
        public override Rover Create(Rover rover, string[] args)
        {
            if (!int.TryParse(args[0], out var x))
            {
                throw new ArgumentException($"Attempted value of {nameof(x)} : {args[0]} is invalid");
            }

            if (!int.TryParse(args[1], out var y))
            {
                throw new ArgumentException($"Attempted value of {nameof(y)} : {args[1]} is invalid");
            }

            var directionArg = args[2];
            if (string.IsNullOrEmpty(directionArg) || !Enum.TryParse(typeof(Direction), directionArg, out var direction))
            {
                throw new ArgumentException($"Attempted value of {nameof(directionArg)} : {args[2]} is invalid");
            }

            return new Rover(x, y, (Direction)direction);
        }
    }
}
