using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korki3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nati, hehe");

            //Console.ReadKey();



            for (int j=0; j < 3; j=j+1)
            {
                //krok1-j
                Console.Write("!");

                //krok2-j
                for (int i = 0; i <= 2; i=i+1)
                {
                    //krok1-i
                    Console.Write("#");
                }//wroc i
            }//wroc j





           // for (int i = 0; i <= 9; i++)

            {
             //   Console.Write("#");
            }
           // Console.WriteLine();
           // for (int i = 0; i <= 8; i++)
            {
                //Console.Write("#");
            }
            Console.ReadKey();

        }
    }
}
