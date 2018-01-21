using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korki_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool wyjdzZpetli = false;
            for (int a = 1; a <= 10; a++) 
            {
                for (int b = 1; b <= 10; b++)
                {
                    if (b % 2 == 0) 
                    {
                        continue;
                    }

                    if (a * b > 50) 
                    {
                        wyjdzZpetli = true;
                        break;
                    }


                    Console.WriteLine(a * b);
                }

                if (wyjdzZpetli == true)
                {
                    break;
                }
            }
            Console.ReadKey();
        }

    }
}
