using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFTest.Core
{
    public interface IUser
    {
        void Go();
        void RotateLeft();
        void RotateRight();
        bool Look();
    }
}
