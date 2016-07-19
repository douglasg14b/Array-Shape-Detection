using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Shape_Detection
{
    public class Point : IEquatable<Point>
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return "["+X+","+Y+"]";
        }

        //IEquatable implimentation so I can do Point == Point
        public bool Equals(Point other)
        {
            if (this.X != other.X) return false;
            if (this.Y != other.Y) return false;

            return true;
        }

        public int X { get; private set; }
        public int Y { get; private set; }
    }
}
