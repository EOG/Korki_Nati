using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korki9
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("piotr","osiak",28);
            

            Osoba o2 = new Osoba("nati","rudzinska",26);
           

            List<Osoba> Ludzie = new List<Osoba>();
            Ludzie.Add(o1);

            Osoba o3 = new Osoba("monika","chmielewska",27);

            Osoba o4 = new Osoba("maciej", "osiak");

            

            Ludzie.Add(o3);
            Ludzie.Add(o2);
            Ludzie.Add(o4);
            Ludzie.Add(new Osoba("zuzanna", "rudzinska", 25));

            
            for (int i = 0; i < Ludzie.Count; i++)
            {
                Console.WriteLine(Ludzie[i].Imie);


            }



            Adres a1 = new Adres("Krakow", "00-123");
            Adres a2 = new Adres("Warszawa", "00-987");

            o1.AdresOsoby = a1;


            o2.Nazwisko = "malinowska";
            for (int i = 0; i < Ludzie.Count; i++)
            {
                Console.WriteLine(Ludzie[i].Imie + " " + Ludzie[i].Nazwisko);


            }

            Console.ReadKey();

        }
    }
}
