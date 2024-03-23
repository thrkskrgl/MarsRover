using MarsRover.Domain.Enums;
using MarsRover.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Services
{
    public interface IRoverService
    {
        void ExecuteCommands(Instruction instruction, Rover rover, Surface surface);
    }
}
