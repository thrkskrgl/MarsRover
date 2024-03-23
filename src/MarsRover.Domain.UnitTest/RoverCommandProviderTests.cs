using MarsRover.Domain.Enums;
using MarsRover.Domain.Providers;

namespace MarsRover.Domain.UnitTest
{
    [TestClass]
    public class RoverCommandProviderTests
    {
        [TestMethod]
        public void NullArgsCanThrowArgumentNullException()
        {
            var provider = new RoverCommandProvider();

            Assert.ThrowsException<ArgumentNullException>(() => provider.Create(null));
        }

        [TestMethod]
        public void EmptyArgsCanThrowArgumentNullException()
        {
            var provider = new RoverCommandProvider();

            Assert.ThrowsException<ArgumentException>(() => provider.Create(""));
        }

        [TestMethod]
        public void GetInstructionsExpectedBehavior()
        {
            var provider = new RoverCommandProvider();

            var instructions = provider.Create("LMMRM");

            Assert.AreEqual(5, instructions.Count());
            Assert.AreEqual(Instruction.L, instructions.ElementAt(0));
            Assert.AreEqual(Instruction.M, instructions.ElementAt(1));
            Assert.AreEqual(Instruction.M, instructions.ElementAt(2));
            Assert.AreEqual(Instruction.R, instructions.ElementAt(3));
            Assert.AreEqual(Instruction.M, instructions.ElementAt(4));
        }
    }
}
