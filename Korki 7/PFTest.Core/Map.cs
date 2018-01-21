using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFTest.Core
{
    public class Map : IMap
    {
        const int DEFAULT_COUNT = 5;
        Point _userPosition;
        int[,] _mapData;
        Dictionary<Point, bool> doors = new Dictionary<Point, bool>();
        int count = DEFAULT_COUNT;

        public Point UserPosition
        {
            get
            {
                return _userPosition;
            }
        }

        public int[,] MapData
        {
            get
            {
                return _mapData;
            }
        }

        public Map(Point userPosition, int[,] mapData)
        {
            _userPosition = userPosition;
            _mapData = mapData;
            for (int x = 0; x < _mapData.GetLength(0); x++)
            {
                for (int y = 0; y < _mapData.GetLength(1); y++)
                {
                    if (_mapData[x, y] == 2)
                    {
                        doors.Add(new Point(x, y), false);
                    }
                }
            }
        }

        public void Go(DirectionEnum direction)
        {
            if (!Peek(direction))
            {
                throw new MapException();
            }
            _userPosition = GetPos(direction);
        }

        public bool Peek(DirectionEnum direction)
        {
            var pos = GetPos(direction);
            if (pos[0] < 0 || pos[0] > _mapData.GetLength(0) || pos[1] < 0 || pos[1] > _mapData.GetLength(1))
                return false;
            var data = _mapData[pos[1], pos[0]];
            if (data == 0)
                return true;
            if (data == 2)
                return doors[pos];
            return false;
        }

        public void Updatate()
        {
            count--;
            if (count <= 0)
            {
                count = DEFAULT_COUNT;
                foreach (var k in doors.Keys)
                {
                    doors[k] = !doors[k];
                }
            }
        }

        private int[] GetPos(DirectionEnum direction)
        {
            int x = _userPosition[0];
            int y = _userPosition[1];
            switch (direction)
            {
                case DirectionEnum.Up:
                    y--;
                    break;
                case DirectionEnum.Left:
                case DirectionEnum.Left2:
                    x--;
                    break;
                case DirectionEnum.Down:
                case DirectionEnum.Down2:
                    y++;
                    break;
                case DirectionEnum.Right:
                case DirectionEnum.Right2:
                    x++;
                    break;
            }
            return new int[] { x, y };
        }
    }
}
