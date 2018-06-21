using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x<6; x++)
            {               

                for (int y = 0; y <5-x; y++)
                {                 
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            





            Console.ReadKey();
        }
    }
}
