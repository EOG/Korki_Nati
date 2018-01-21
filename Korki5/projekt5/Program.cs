using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt5
{
    class Program
    {
        static void Main(string[] args)
        {

            int suma = 0;

            for (int f = 0; f <= 10; f++)
            {
                suma = f + suma;
            }
            Console.WriteLine(suma);

            Console.ReadKey();

            suma = 2 + 2;
            suma = 1 + 6;




        }

    }
}
