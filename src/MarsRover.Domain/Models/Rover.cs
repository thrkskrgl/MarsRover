using MarsRover.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Models
{
    public class Rover(int x, int y, Direction direction)
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;
        public Direction Direction { get; protected set; } = direction;

        public void TurnLeft()
        {
            Direction = (Direction)(((int)Direction + 3) % 4);
        }

        public void TurnRight()
        {
            Direction = (Direction)(((int)Direction + 1) % 4);
        }

        public void MoveForward(Surface surface)
        {
            switch (Direction)
            {
                case Direction.N:
                    if (Y < surface.MaxY) Y++;
                    break;
                case Direction.E:
                    if (X < surface.MaxX) X++;
                    break;
                case Direction.S:
                    if (Y > 0) Y--;
                    break;
                case Direction.W:
                    if (X > 0) X--;
                    break;
            }
        }
    }
}
