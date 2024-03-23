using MarsRover.Domain.Models;

namespace MarsRover.Domain.Providers
{
    public class SurfaceProvider : ProviderBase<Surface>, ISurfaceProvider
    {
        public override Surface Create(Surface surface, string[] args)
        {
            if (!int.TryParse(args[0], out var maxX) || maxX < 1)
            {
                throw new ArgumentException($"Attempted value of {nameof(maxX)} : {args[0]} is invalid");
            }

            if (!int.TryParse(args[1], out var maxY) || maxY < 1)
            {
                throw new ArgumentException($"Attempted value of {nameof(maxY)} : {args[1]} is invalid");
            }

            return new Surface(maxX, maxY);
        }
    }
}
