using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korki_10
{
    //tu robimy klase
    class Zwierze
    {
        //tutaj mowimy jakie klasa ma wartosci
        public string imie;
        public string gatunek;
        public int wiek;
        public bool czyzywe;

        //konstruktor bezargumentowy, pozwana na zrobienie new Zwierze()
        public Zwierze()
        {
           
        }

        //konstuktor z argumentami pozwala na new Zwierze("Pyza", "Popierdółka", 4)
        public Zwierze(string imie, string gatunek, int wiek)
        {
            //tutaj przypisujemy argumenty z konstruktora do wartości klasy
            this.imie = imie;
            this.gatunek = gatunek;
            this.wiek = wiek;
            this.czyzywe = true;
        }

        //to jestm metoda która mowi ile zwierze bedzie mialo lat za 5 lat
        public int Za5Lat()
        {
            return this.wiek + 5;
        }

        //tutaj mowimy ze zwirze.ToString ma się normalnie przedstawiać
        public override string ToString()
        {
            //zajrzyj do notatek
            return $"Mam na imie:{this.imie}, gatunku:{this.gatunek}, i lat:{this.wiek}";
        }
    }

    
}
