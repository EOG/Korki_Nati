using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello!";

            for(int y= 0; y < 6; y++)
            {
                Console.WriteLine(x);
            }


            string z = "Bye! Bye!";

            for(int a=0; a<2; a++)
            {               
                for(int b=0;b<3;b++)
                {
                    Console.WriteLine(z);
                }


            }

            Console.ReadKey();
        }
        
    }


    
}
