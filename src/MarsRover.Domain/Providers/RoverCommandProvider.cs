using MarsRover.Domain.Enums;

namespace MarsRover.Domain.Providers
{
    public class RoverCommandProvider : IRoverCommandProvider
    {
        public IEnumerable<Instruction> Create(string args)
        {
            ArgumentException.ThrowIfNullOrEmpty(args);

            return args.Select(arg =>
            {
                if (Enum.TryParse(arg.ToString().ToUpper(), out Instruction instruction))
                {
                    return instruction;
                }
                else
                {
                    throw new ArgumentException($"Valid values: {string.Join(", ", Enum.GetNames(typeof(Instruction)))}");
                }
            });
        }
    }
}
