using PFTest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFTest
{
    class FakeUser : IUser
    {
        public enum UserCMDEnum
        {
            Go,
            Look,
            Left,
            Right
        }

        Queue<UserCMDEnum> _cmds;

        public FakeUser(Queue<UserCMDEnum> cmds)
        {
            _cmds = cmds;
        }

        public void Go()
        {
            _cmds.Enqueue(UserCMDEnum.Go);
        }

        public bool Look()
        {
            _cmds.Enqueue(UserCMDEnum.Look);
            return true;
        }

        public void RotateLeft()
        {
            _cmds.Enqueue(UserCMDEnum.Left);
        }

        public void RotateRight()
        {
            _cmds.Enqueue(UserCMDEnum.Right);
        }
    }
}
