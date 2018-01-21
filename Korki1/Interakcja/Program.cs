using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interakcja
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "";
            string t2;
 //komentarz, ktory nie jest wykonywany po dwoch nawiasach
            Console.WriteLine("wprowadź jakiś tekst"); //WriteLine- wypisz na ekran i dodaj linię 

            tekst = Console.ReadLine(); //Przeczytaj, co wprowadziłem dopóki nie nacisnę enter

            Console.WriteLine("wpisałeś: " + tekst);



            Console.WriteLine("ile masz lat?");
            string tekst2 = Console.ReadLine();
            Console.WriteLine("jak masz na imię?");
            tekst = Console.ReadLine();

            Console.WriteLine("jesteś " + tekst);


            Console.WriteLine("masz " + tekst2);

            Console.ReadKey(); 
        }
    }
}
