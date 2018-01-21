using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFTest.Core
{
    public interface IUserRenderer
    {
        DirectionEnum Direction { get; }
        void Set(IMap map, DirectionEnum direction);
    }
}
