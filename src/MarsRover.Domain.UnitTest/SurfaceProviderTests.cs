using MarsRover.Domain.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.UnitTest
{
    [TestClass]
    public class SurfaceProviderTests
    {
        [TestMethod]
        public void GetSurfaceExpectedBehavior()
        {
            var provider = new SurfaceProvider();

            string[] args = ["5", "5"];

            var surface = provider.Create(null, args);

            Assert.IsNotNull(surface);
            Assert.AreEqual(5, surface.MaxX);
            Assert.AreEqual(5, surface.MaxY);
        }

        [TestMethod]
        public void InvalidArgumentsCanThrowArgumentException()
        {
            var provider = new SurfaceProvider();

            string[] invalidArgs = ["-5", "5"];

            Assert.ThrowsException<ArgumentException>(() => provider.Create(null, invalidArgs));
        }
    }
}
