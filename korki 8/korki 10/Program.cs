using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korki_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaslow = 6; 
            string[] tablica = new string[liczbaslow];
            

            
            for (int i = 0; i < liczbaslow; i++)
            {
                tablica[i] = Console.ReadLine();

            }
            for (int j = 0; j < liczbaslow; j++)
            {
                Console.WriteLine(tablica[j]);
            }
            Console.ReadKey();
        }
        

    }
}
