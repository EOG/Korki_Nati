using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie = "";          
            Console.WriteLine("Witamy w kreatorze CV!");

            Console.WriteLine("Wprowadź imię i nazwisko");
            imie = Console.ReadLine();

            Console.WriteLine("Wpisałeś:" +imie);

            
            Console.WriteLine("Wprowadź wiek");
            string y = Console.ReadLine();

            Console.WriteLine("Wpisałeś:" +y);

            string z = "";
            Console.WriteLine("Wprowadź płeć");
            z = Console.ReadLine();

            Console.WriteLine("Wpisałeś:" +z);


            string a;
            Console.WriteLine("Wprowadź obecnie wykonywany zawód");
            a = Console.ReadLine();

            Console.WriteLine("Wpisałeś:" +a);

            Console.WriteLine("Nazywasz się:" +imie);
            Console.WriteLine("Masz:" +y + " lat");
            Console.WriteLine("Jesteś:" +z);
            Console.WriteLine("Twój zawód to:" +a);

            Console.WriteLine("Chyba działa XD");


            Console.ReadKey();

        }
    }
}
