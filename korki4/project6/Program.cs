using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int licz = 100; licz < 200; licz = licz + 10)
            {
                 for (int iks = 0; iks < 10; iks++)
                {
                    Console.Write(licz + iks);
                    Console.Write(" ");

                }
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }
}
