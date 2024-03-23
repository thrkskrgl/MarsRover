using MarsRover.Domain.Enums;
using MarsRover.Domain.Models;
using MarsRover.Domain.Services;

namespace MarsRover.Domain.UnitTest
{
    [TestClass]
    public class RoverServiceTests
    {
        [TestMethod]
        public void TurnLeftExpectedBehavior()
        {
            var service = new RoverService();
            var rover = new Rover(0, 0, Direction.N);
            var surface = new Surface(5, 5);

            service.ExecuteCommands(Instruction.L, rover, surface);

            Assert.AreEqual(Direction.W, rover.Direction);
        }

        [TestMethod]
        public void TurnRightExpectedBehavior()
        {
            var service = new RoverService();
            var rover = new Rover(0, 0, Direction.N);
            var surface = new Surface(5, 5);

            service.ExecuteCommands(Instruction.R, rover, surface);

            Assert.AreEqual(Direction.E, rover.Direction);
        }

        [TestMethod]
        public void MoveForwardExpectedBehavior()
        {
            var service = new RoverService();
            var rover = new Rover(0, 0, Direction.N);
            var surface = new Surface(5, 5);

            service.ExecuteCommands(Instruction.M, rover, surface);

            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(1, rover.Y);
        }

        [TestMethod]
        public void NullRoverCanThrowArgumentException()
        {
            var service = new RoverService();
            Rover rover = null;
            var surface = new Surface(5, 5);

            Assert.ThrowsException<ArgumentNullException>(() => service.ExecuteCommands(Instruction.M, rover, surface));
        }

        [TestMethod]
        public void InvalidInstructionCanThrowArgumentException()
        {
            var service = new RoverService();
            var rover = new Rover(0, 0, Direction.N);
            var surface = new Surface(5, 5);

            Assert.ThrowsException<ArgumentException>(() => service.ExecuteCommands((Instruction)99, rover, surface));
        }
    }
}
