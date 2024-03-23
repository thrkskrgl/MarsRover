using MarsRover.Domain.Models;

namespace MarsRover.Domain.Providers
{
    public interface IAggregateArgsProvider
    {
        AggregateArgs Create(string[] args);
    }
}
