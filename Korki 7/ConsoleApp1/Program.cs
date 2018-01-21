using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznik = 50;
            while (licznik < 16)
            {
                licznik++;
            }
            Console.WriteLine(licznik);
            Console.ReadKey();
        }
    }
}
