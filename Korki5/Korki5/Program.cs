using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korki5
{
    class Program
    {
        static void Main(string[] args)
        {
            string r;
            string p = "pies";

            //Console.WriteLine("r = " + r);
            //Console.WriteLine("p = " + p);

            Console.WriteLine("Wpisz wartość r");
            r = Console.ReadLine();
       
            Console.WriteLine("Wpisałeś");

            Console.WriteLine("r = " + r);
            Console.WriteLine("p = " + p);

            string p2;

            p2 = p;
            p = r;
            r = p2;


            Console.WriteLine("r = " + r);
            Console.WriteLine("p = " + p);


            Console.ReadKey();

        }
    }

}
