using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleLatZa5Lat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile masz lat?");
            string ileLat = Console.ReadLine();

            int lata = int.Parse(ileLat); //Metoda Parse służy do zmiany tekstu w liczbę (lub cokolwiek innego np. w datę)
            int za5Lat = lata + 5;
            Console.WriteLine("Za 5 lat będziesz mieć " + za5Lat + " lata");
            Console.ReadKey();
        }
    }
}
