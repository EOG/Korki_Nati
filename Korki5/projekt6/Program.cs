using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt6
{
    class Program
    {
        static void Main(string[] args)
        {
            int koszyk1 = 100;
            int koszyk2 = 200;

            Console.WriteLine("dzielna = " + koszyk1);
            Console.WriteLine("dzielnik = " + koszyk2);

            int tymczasowa;
            tymczasowa = koszyk1; 

            koszyk1 = koszyk2;
            koszyk2 = tymczasowa;

            Console.WriteLine("dzielna = " + koszyk1);
            Console.WriteLine("dzielnik = " + koszyk2);


            Console.ReadKey();

        }


    }
}
