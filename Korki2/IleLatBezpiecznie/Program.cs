using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleLatBezpiecznie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile masz lat?");
            string ileLat = Console.ReadLine();

            int lata;
            bool czyLiczba = int.TryParse(ileLat, out lata);

            if (czyLiczba == true)
            {
                int za5Lat = lata + 5;
                Console.WriteLine("Za 5 lat będziesz mieć " + za5Lat + " lata");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("To nara");
                Console.ReadKey();

            }
        }
    }
}
