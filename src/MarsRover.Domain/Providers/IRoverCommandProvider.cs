using MarsRover.Domain.Enums;
using MarsRover.Domain.Models;

namespace MarsRover.Domain.Providers
{
    public interface IRoverCommandProvider
    {
        IEnumerable<Instruction> Create(string args);
    }
}
