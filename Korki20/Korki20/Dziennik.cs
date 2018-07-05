using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korki20
{
    public class Dziennik
    {
        public List<Uczen> ListaUczniow { get; set; }
        
        //metoda:
        public void WypelnijDziennik(string imie1, string nazwisko1, string imie2, string nazwisko2, string nazwaPrzedmiot1, string nazwaPrzedmiot2) //dodajemy dowolne argumenty
        {
            Uczen uczen1 = new Uczen();  //za new zawsze wystepuje cos co jest metoda, wiec ()
            Uczen uczen2 = new Uczen();


            uczen1.Name = imie1 + " " + nazwisko1;
            uczen2.Name = imie2 + " " + nazwisko2;



            Przedmiot p1 = new Przedmiot(); //nowa instancja klasy Przedmiot
            p1.Nazwa = nazwaPrzedmiot1; //wynika z propertisa Nazwa, dowolna nazwa Przedmiotu i wynika z argumentu przekazanego do metody WypelnijDziennik
            
            Przedmiot p2 = new Przedmiot();
            p2.Nazwa = nazwaPrzedmiot2;

            uczen1.ListaPrzedmiotow = new List<Przedmiot>(); //properties na początku nie mają watości, dlatego prosimy o nową listę
            uczen1.ListaPrzedmiotow.Add(p1); //dodajemy przez listę, bo klasa Uczen ma properties który jest listą
            uczen1.ListaPrzedmiotow.Add(p2);

            uczen2.ListaPrzedmiotow = new List<Przedmiot>();
            uczen2.ListaPrzedmiotow.Add(p1);
            uczen2.ListaPrzedmiotow.Add(p2);




        }
    }
}
