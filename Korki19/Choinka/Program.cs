using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 6; x++) 
            {
                for (int y = 0; y< x; y++) //X TO JEST TA LICZBA, KTÓRA ROŚNIE O 1!!!!!!!!!!!!
                {
                    Console.Write("#");                   
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
