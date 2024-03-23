using MarsRover.Domain.Models;

namespace MarsRover.Domain.UnitTest
{
    [TestClass]
    public class SurfaceTests
    {
        [TestMethod]
        public void CanSetAndGetProps()
        {
            int testValueX = 5;
            int testValueY = 10;

            var surface = new Surface(testValueX, testValueY);

            Assert.AreEqual(testValueX, surface.MaxX);
            Assert.AreEqual(testValueY, surface.MaxY);
        }
    }
}
