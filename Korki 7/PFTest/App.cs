using PFTest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PFTest
{
    abstract class App
    {
        protected virtual Map map
        {
            get
            {
                return new Map(new Point(1, 1), new int[5, 5]
                {
                    { 1, 1, 1, 1, 1 },
                    { 1, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 1 },
                    { 1, 1, 1, 1, 1 },
                });
            }
        }

        User user;
        Map drawMap;

        protected IUser User
        {
            get;
            private set;
        }

        protected abstract void Movement();

        protected Queue<FakeUser.UserCMDEnum> cmds;

        public App()
        {
            drawMap = map;
            var user = new User();
            user.Set(drawMap, DirectionEnum.Up);
            this.user = user;

            cmds = new Queue<FakeUser.UserCMDEnum>();

            User = new FakeUser(cmds);

            Movement();
        }

        public void Update()
        {
            while (true)
            {
                Redraw(drawMap, user);
                Thread.Sleep(250);
                //var key = Console.ReadKey();
                //switch (key.Key)
                //{
                //    case ConsoleKey.UpArrow:
                //        user.Go();
                //        break;
                //    case ConsoleKey.LeftArrow:
                //        user.RotateLeft();
                //        break;
                //    case ConsoleKey.RightArrow:
                //        user.RotateRight();
                //        break;
                //    default:
                //        break;
                //}
                if (cmds.Count > 0)
                {
                    var cmd = cmds.Dequeue();
                    switch (cmd)
                    {
                        case FakeUser.UserCMDEnum.Go:
                            user.Go();
                            break;
                        case FakeUser.UserCMDEnum.Look:
                            user.Look();
                            break;
                        case FakeUser.UserCMDEnum.Left:
                            user.RotateLeft();
                            break;
                        case FakeUser.UserCMDEnum.Right:
                            user.RotateRight();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        void Redraw(Map map, User user)
        {
            Console.Clear();
            for (int x = 0; x < map.MapData.GetLength(0); x++)
            {
                for (int y = 0; y < map.MapData.GetLength(1); y++)
                {
                    if (map.UserPosition.Y == x && map.UserPosition.X == y)
                    {
                        switch (user.Direction)
                        {
                            case DirectionEnum.Up:
                                Console.Write('▲');
                                break;
                            case DirectionEnum.Left:
                            case DirectionEnum.Left2:
                                Console.Write('◄');
                                break;
                            case DirectionEnum.Down:
                            case DirectionEnum.Down2:
                                Console.Write('▼');
                                break;
                            case DirectionEnum.Right:
                            case DirectionEnum.Right2:
                                Console.Write('►');
                                break;
                            default:
                                break;
                        }
                        continue;
                    }
                    if (map.MapData[x, y] > 0)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"USER X:{map.UserPosition.X}, Y:{map.UserPosition.Y}");
        }
    }
}
