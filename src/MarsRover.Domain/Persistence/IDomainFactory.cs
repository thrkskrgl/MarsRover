using MarsRover.Domain.Providers;
using MarsRover.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Persistence
{
    public partial interface IDomainFactory
    {
        IRoverService GetRoverService();
        IAggregateArgsProvider GetAggregateArgsProvider();
        IRoverLocationProvider GetRoverLocationProvider();
        ISurfaceProvider GetSurfaceProvider();
        IRoverCommandProvider GetRoverCommandProvider();
    }
}
