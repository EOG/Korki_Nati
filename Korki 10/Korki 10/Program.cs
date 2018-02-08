using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korki_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzywamy konstruktowa bezargumentowego
            Zwierze zolw = new Zwierze();
            zolw.imie = "Seba";
            zolw.gatunek = "gad";
            zolw.wiek = 85;
            zolw.czyzywe = true;

            //argumentiowego
            Zwierze chomik = new Zwierze("Maniek","ssak", 2);
            Zwierze papuga = new Zwierze("Pikachu", "ptak", 55);

            Console.WriteLine(chomik.ToString());

            Console.WriteLine(chomik.Za5Lat());

            Zwierze[] TablicaZwierzat = new Zwierze[100];

            string[] napisy = new string[5] { "chomik", "zolw", "papuga", "", "" };

            napisy[4] = "kon";
            napisy[3] = "kanarek";

            TablicaZwierzat[1] = chomik;
            TablicaZwierzat[2] = papuga;
            TablicaZwierzat[3] = new Zwierze("Rysio", "wonsz", 10);


            Zwierze wonsz = TablicaZwierzat[3];

            Console.WriteLine(wonsz.ToString());

        }
    }
}
