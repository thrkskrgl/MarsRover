using MarsRover.Domain.Models;

namespace MarsRover.Domain.UnitTest
{
    [TestClass]
    public class AggregateArgsTests
    {
        [TestMethod]
        public void SurfaceCoordinatesIsCorrectlySet()
        {
            var args = new AggregateArgs();
            string surfaceCoordinates = "5 5";

            args.SurfaceCoordinates = surfaceCoordinates;

            Assert.AreEqual(surfaceCoordinates, args.SurfaceCoordinates);
        }

        [TestMethod]
        public void NullSurfaceCoordinatesCanThrowArgumentNullException()
        {
            var args = new AggregateArgs();

            Assert.ThrowsException<ArgumentNullException>(() => args.SurfaceCoordinates = null);
            Assert.ThrowsException<ArgumentNullException>(() => args.SurfaceCoordinates = string.Empty);
        }

        [TestMethod]
        public void InitialLocationWithCommandsAreCorrectlySet()
        {
            var args = new AggregateArgs();
            var initialLocationWithCommands = new List<(string, string)>
            {
                ("1 2 N", "LMLMLMLMM"),
                ("3 3 E", "MMRMMRMRRM")
            };

            args.InitialLocationWithCommands = initialLocationWithCommands;

            Assert.AreEqual(initialLocationWithCommands.Count, args.InitialLocationWithCommands.Count);
            Assert.IsTrue(args.InitialLocationWithCommands.All(tuple => !string.IsNullOrEmpty(tuple.Item1) && !string.IsNullOrEmpty(tuple.Item2)));
        }

        [TestMethod]
        public void NullInitialLocationWithCommandsCanThrowArgumentNullException()
        {
            var args = new AggregateArgs();

            Assert.ThrowsException<ArgumentNullException>(() => args.InitialLocationWithCommands = null);
        }
    }
}
