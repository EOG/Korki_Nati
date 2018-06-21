using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie55
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> listaliczb = new List<double>();
            Random random = new Random();

            for (int x = 0; x < 100; x++)
            {
                listaliczb.Add(random.NextDouble()*1000);
            }


            listaliczb.Sort();

            for (int y = 0; y < 100; y++) 
            {
                Console.WriteLine(listaliczb[y]);

            }

          




            Console.ReadKey();
        }

      

    }
}
