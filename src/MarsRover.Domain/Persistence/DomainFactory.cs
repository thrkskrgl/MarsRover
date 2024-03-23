using MarsRover.Domain.Providers;
using MarsRover.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Persistence
{
    public partial class DomainFactory : IDomainFactory
    {
        public IAggregateArgsProvider GetAggregateArgsProvider()
        {
            return new AggregateArgsProvider();
        }

        public IRoverCommandProvider GetRoverCommandProvider()
        {
            return new RoverCommandProvider();
        }

        public IRoverLocationProvider GetRoverLocationProvider()
        {
            return new RoverLocationProvider();
        }

        public IRoverService GetRoverService()
        {
            return new RoverService();
        }

        public ISurfaceProvider GetSurfaceProvider()
        {
            return new SurfaceProvider();
        }
    }
}
