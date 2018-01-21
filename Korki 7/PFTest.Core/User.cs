using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFTest.Core
{
    public class User : IUser, IUserRenderer
    {
        private IMap _map;

        public DirectionEnum Direction { get; set; }

        public void Set(IMap map, DirectionEnum direction)
        {
            _map = map;
            Direction = direction;
        }

        public bool Look()
        {
            return _map.Peek(Direction);
        }

        public void RotateLeft()
        {
            int current = (int)Direction;
            current++;
            current %= 4;
            Direction = (DirectionEnum)current;
        }

        public void RotateRight()
        {
            int current = (int)Direction;
            current--;
            current %= 4;
            Direction = (DirectionEnum)(current);
        }

        public void Go()
        {
            _map.Go(Direction);
        }
    }
}
