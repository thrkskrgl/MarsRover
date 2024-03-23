using MarsRover.Domain.Enums;
using MarsRover.Domain.Models;

namespace MarsRover.Domain.UnitTest
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void CanSetAndGetProps()
        {
            int testValueX = 5;
            int testValueY = 10;
            Direction direction = default;

            var rover = new Rover(testValueX, testValueY, direction);

            Assert.AreEqual(testValueX, rover.X);
            Assert.AreEqual(testValueY, rover.Y);
            Assert.AreEqual(direction, rover.Direction);
        }
    }
}
