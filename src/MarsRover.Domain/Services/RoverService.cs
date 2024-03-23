using MarsRover.Domain.Enums;
using MarsRover.Domain.Models;

namespace MarsRover.Domain.Services
{
    public partial class RoverService : IRoverService
    {
        public RoverService() 
        {
        }

        public void ExecuteCommands(Instruction instruction, Rover rover, Surface surface)
        {
            ArgumentNullException.ThrowIfNull(rover);
            switch (instruction)
            {
                case Instruction.L:
                    rover.TurnLeft();
                    break;
                case Instruction.R:
                    rover.TurnRight();
                    break;
                case Instruction.M:
                    rover.MoveForward(surface);
                    break;
                default:
                    throw new ArgumentException($"Invalid instruction: {instruction}");
            }
        }
    }
}