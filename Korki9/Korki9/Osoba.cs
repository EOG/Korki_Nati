using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korki9
{
    public class Osoba
    {
        public string Imie;
        public string Nazwisko;
        public int Wiek;
        public Adres AdresOsoby;
        

        public Osoba(string imie, string nazwisko, int wiek)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
        }

        public Osoba(string imie, string nazwisko)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = -1;
        }
    }
}
