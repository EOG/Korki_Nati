using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_z_pilka
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilka x = new Pilka();
            Pilka y = new Pilka();
            Pilka noga = new Pilka();

            List<Pilka> pilki = new List<Pilka>();

            noga.UstawNazwe("Pilka do nogi"); //klasy mozna traktowac jako zmienna

            y.UstawNazwe("Pilka do kosza"); //trzeba dac po zmiennej kropke; wowczas pokaza sie opcje

            x.UstawNazwe("Pilka do rugby");

            Console.WriteLine(noga.Nazwa);
            Console.WriteLine(y.Nazwa);
            Console.WriteLine(x.Nazwa);



            Console.ReadKey();
        }

        
    }
}
