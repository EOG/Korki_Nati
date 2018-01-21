using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            //to nie jest program tylko przykład jak można porównywać
            bool czyRuda = true;
            bool czyKot = true;
            //pyza
            if (czyRuda == true && czyKot == true)
            {
                Console.WriteLine("Jest ruda i jest kotem");
            }

            //Nati
            if (czyRuda == true && czyKot == false)
            {
                Console.WriteLine("Jestem ruda i nie jestem kotem");
            }

                              
        }
    }
}
