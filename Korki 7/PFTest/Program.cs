using PFTest.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var app = new MyApp();
            while (true)
            {
                try
                {
                    app.Update();
                }
                catch (MapException e)
                {
                    Console.Clear();
                    Console.WriteLine("Game Over");
                    Console.ReadKey();
                    app = new MyApp();
                }
            }
        }


    }
}
