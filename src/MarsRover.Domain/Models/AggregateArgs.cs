using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Models
{
    public partial class AggregateArgs
    {
        private string _surfaceCoordinates;
        private List<(string, string)> _initialLocationWithCommands;

        public string SurfaceCoordinates
        {
            get => _surfaceCoordinates;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("SurfaceCoordinates cannot be null or empty.");
                _surfaceCoordinates = value;
            }
        }

        public List<(string, string)> InitialLocationWithCommands
        {
            get => _initialLocationWithCommands ??= new List<(string, string)>();
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(InitialLocationWithCommands), "InitialLocationWithCommands cannot be null.");
                _initialLocationWithCommands = value;
            }
        }
    }
}
