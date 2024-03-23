using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Providers
{
    public interface IProviderBase<T> where T : class
    {
        T Initialize(string args);
    }
}
