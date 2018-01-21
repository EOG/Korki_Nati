using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaslow = 3;
            //string[] tablica = new string[liczbaslow];
            List<string> koty = new List<string>();
            

            koty.Add("aaa"); //el 1
            for (int i = 0; i < liczbaslow; i++)
            {
                koty.Add (Console.ReadLine()); //el 2 - 7

            }
            liczbaslow = 0;

            for (int j = 0; j < koty.Count; j++)
            {
                Console.WriteLine(koty[j]);
            }
            Console.ReadKey();
        }


    }
}

