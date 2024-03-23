using MarsRover.Domain.Providers;

namespace MarsRover.Domain.UnitTest
{
    [TestClass]
    public class AggregateArgsProviderTests
    {
        [TestMethod]
        public void GetAggregateArgsExpectedBehavior()
        {
            var provider = new AggregateArgsProvider();
            var args = new string[]
            {
            "5 5",
            "1 2 N", "LMLMLMLMM",
            "3 3 E", "MMRMMRMRRM"
            };

            var result = provider.Create(args);

            Assert.AreEqual("5 5", result.SurfaceCoordinates);

            Assert.AreEqual(2, result.InitialLocationWithCommands.Count);
            Assert.AreEqual(("1 2 N", "LMLMLMLMM"), result.InitialLocationWithCommands[0]);
            Assert.AreEqual(("3 3 E", "MMRMMRMRRM"), result.InitialLocationWithCommands[1]);
        }

        [TestMethod]
        public void NullArgsCanThrowArgumentNullException()
        {
            var provider = new AggregateArgsProvider();

            Assert.ThrowsException<ArgumentNullException>(() => provider.Create(null));
        }

        [TestMethod]
        public void LessArgsCanThrowArgumentException()
        {
            var provider = new AggregateArgsProvider();
            var args = new string[2];

            Assert.ThrowsException<ArgumentException>(() => provider.Create(args));
        }
    }
}