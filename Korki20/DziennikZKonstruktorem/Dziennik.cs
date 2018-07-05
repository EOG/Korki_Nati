using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziennikZKonstruktorem
{
    public class Dziennik
    {
        public List<UczenZKonstruktorem> ListaUczniow { get; set; }

        
        public void WypelnijDziennik(string imie1, string nazwisko1, string imie2, string nazwisko2, string nazwaPrzedmiot1, string nazwaPrzedmiot2)
        {
            PrzedmiotZKonstruktorem p1 = new PrzedmiotZKonstruktorem(nazwaPrzedmiot1);
            PrzedmiotZKonstruktorem p2 = new PrzedmiotZKonstruktorem(nazwaPrzedmiot2);

            UczenZKonstruktorem u1 = new UczenZKonstruktorem(imie1, nazwisko1);
            UczenZKonstruktorem u2 = new UczenZKonstruktorem(imie2, nazwisko2);


            u1.ListaPrzedmiotow.Add(p1);
            u1.ListaPrzedmiotow.Add(p2);

            u2.ListaPrzedmiotow.Add(p1);
            u2.ListaPrzedmiotow.Add(p2);

            ListaUczniow = new List<UczenZKonstruktorem>(); //teraz trzeba poprosic o nowa listę

            ListaUczniow.Add(u1);
            ListaUczniow.Add(u2);

        }


    }
}
