using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool x = 2 == 2; //sprawdzamy czy 2 jest równe 2
            bool y = 3 * 6 == 18; //sprawdzamy czy 3*6 jest równe 18
            bool z = 9 * 3 == 81;//sprawdzamy czy 9*3 jest rowne 81

            if (x == true) //jezeli x jest prawdą to wykonaj kod w bloku 
            {
                Console.WriteLine("Nati");
            }

            bool a = "kot" == "k" + "o" + "t";
            if (a == true)
            {
                Console.WriteLine("Tuńczyk");

            }

            bool b = "herbata" == Console.ReadLine();
            bool piotr = Console.ReadLine() == "piotr";
            if (b== true)
            {
                Console.WriteLine("hehe");
            }
            else if(piotr == true) //to sie wyswietli, tylko jezeli pierwsze nie bedzie "herbata'
            {
                Console.WriteLine("ppp");
            }
            else
            {
                Console.WriteLine("kawa");
            }

            Console.ReadKey();


        
        }
    }
}
