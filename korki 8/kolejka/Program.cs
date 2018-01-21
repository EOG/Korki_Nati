using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolejka
{
    class Program
    {
        static void Main(string[] args)
        {

            int liczbaslow = 3;
            //string[] tablica = new string[liczbaslow];
            //List<string> koty = new List<string>();
            Queue<string> psy = new Queue<string>();


            psy.Enqueue("aaa"); //el 1
            for (int i = 0; i < liczbaslow; i++)
            {
                psy.Enqueue(Console.ReadLine()); //el 2 - 7

            }
            liczbaslow = 0;
            int wkolejce = psy.Count;
            for (int j = 0; j < wkolejce; j++)
            {
                Console.WriteLine(psy.Dequeue());
            }
            Console.ReadKey();
        }
    }

}
