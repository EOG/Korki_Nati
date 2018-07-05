using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziennikZKonstruktorem
{
    class Program
    {
        static void Main(string[] args)
        {

            //PrzedmiotZKonstruktorem p1 = new PrzedmiotZKonstruktorem();
            //p1.NazwaPrzedmiotu = "Matematyka";

            PrzedmiotZKonstruktorem p1 = new PrzedmiotZKonstruktorem("Matematyka"); //ta jedna linia robi to samo co dwie linie 14 i 15




            Dziennik d1 = new Dziennik();
            d1.WypelnijDziennik("Piotr", "Osiak", "Monika", "Chmielewska", "Matematyka", "Fizyka");
                




        }
    }
}
