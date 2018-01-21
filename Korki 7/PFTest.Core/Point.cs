using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFTest.Core
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(int[] pos)
            : this(pos[0], pos[1])
        {

        }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                    return X;
                if (index == 1)
                    return Y;
                throw new IndexOutOfRangeException();
            }
        }

        public static bool operator ==(Point first, Point other)
        {
            return first.X == other.X && first.Y == other.Y;
        }

        public static bool operator !=(Point first, Point other)
        {
            return !(first == other);
        }

        public static implicit operator Point(int[] pos)
        {
            return new Point(pos);
        }

        public override int GetHashCode()
        {
            return X + Y;
        }
    }
}
