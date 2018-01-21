using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstrukcjeWarunkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prawda = true;
            bool niePrawda = false;

            if (prawda)
            {
                Console.WriteLine("Prawda więc wyświetlę");
            }
            if (niePrawda)
            {
                Console.WriteLine("Fałsz więc nie wyświetlę");
            }
            if (true)
            {
                Console.WriteLine("Prawda bezpośrednia");
            }


            bool czyPrawda = 1 + 1 == 2;
            bool czyFalsz = 2 + 2 != 5;
            Console.WriteLine("czyPrawda: " + czyPrawda);
            Console.WriteLine("czyFalsz: " + czyFalsz);

            Console.ReadKey();

            if (15 / 3 == 5)
            {
                Console.WriteLine("Tak to prawda");
            }

            Console.WriteLine("Uber czy Taxi (u/t)");
            char uberCzyTaxi = Console.ReadKey().KeyChar;

            if (uberCzyTaxi == 'u')
            {
                Console.WriteLine("Uber");
            }
            else if (uberCzyTaxi == 't') //jezeli if jest klamstwem, to sie wykona
            {
                Console.WriteLine("Taxi");
            }
            else //jesli else if jest klamstwem, to sie wykona
            {
                Console.WriteLine("Ani Uber ani Taxi");
            }

            Console.ReadKey();
            //--------- AND -----------
            if (true && true)
            {
                Console.WriteLine("Prawda - true && true");
            }

            if (true && false)
            {
                Console.WriteLine("Fałsz - true && false");
            }

            Console.WriteLine("Naciśnij 't' na klawiaturze");
            if (Console.ReadKey().KeyChar == 't' && true)
            {
                Console.WriteLine("Prawda - 't' && true");
            }
            else
            {
                Console.WriteLine("Ej weź, co ty robisz w ogóle :C");
            }

            if (false && Console.ReadKey().KeyChar == 't')
            {
                Console.WriteLine("Program się tu nie zatrzyma bo pierszy jest fałsz");
            }
            Console.ReadKey();
            //--------- OR ---------
            if (false || true)
            {
                Console.WriteLine("To widzimy - false || true");
            }
            if (true || false)
            {
                Console.WriteLine("To też - true || false");
            }
            if (true || true)
            {
                Console.WriteLine("To też - true || true");
            }
            if (false || false)
            {
                Console.WriteLine("To też - false || false");
            }
            Console.WriteLine("Jeszcze raz naciśnij 't'");
            bool t = Console.ReadKey().KeyChar == 't';
            if (false || t)
            {
                Console.WriteLine("Program się zatrzymał wiec dziala poprawnie - false || 't'");
            }

            if (true && true || false && true)
            {
                Console.WriteLine("Możemy tak łaczyć");
            }
            if (false || (true && false))
            {
                Console.WriteLine("Nazwiazy nadają priorytet");
            }
            Console.ReadKey();

        }
    }
}
