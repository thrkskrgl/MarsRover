using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Models
{
    public class Surface(int maxX, int maxY)
    {
        public int MaxX { get; } = maxX;
        public int MaxY { get; } = maxY;
    }
}
