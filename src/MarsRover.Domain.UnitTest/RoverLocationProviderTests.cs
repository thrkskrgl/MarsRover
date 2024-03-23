using MarsRover.Domain.Enums;
using MarsRover.Domain.Providers;

namespace MarsRover.Domain.UnitTest
{
    [TestClass]
    public class RoverLocationProviderTests
    {
        [TestMethod]
        public void GetRoverLocationExpectedBehavior()
        {
            var provider = new RoverLocationProvider();

            string[] args = ["1", "2", "N"];

            var rover = provider.Create(null, args);

            Assert.IsNotNull(rover);
            Assert.AreEqual(1, rover.X);
            Assert.AreEqual(2, rover.Y);
            Assert.AreEqual(Direction.N, rover.Direction);
        }

        [TestMethod]
        public void InvalidArgumentsCanThrowArgumentException()
        {
            var provider = new RoverLocationProvider();

            string[] invalidArgs = ["invalid", "2", "N"];

            Assert.ThrowsException<ArgumentException>(() => provider.Create(null, invalidArgs));
        }
    }
}
