using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFTest.Core
{
    public interface IMap
    {
        bool Peek(DirectionEnum direction);
        void Go(DirectionEnum direction);
    }
}
