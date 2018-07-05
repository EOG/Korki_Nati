using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class ZadaniaLista
    {
        public void Zadanie1()
        {
            string hello = "siemka"; //typ nazwa = wartosc

            List<string> listaNapisow = new List<string>(); //typ nazwa = wartosc
            listaNapisow.Add("jakis napis"); //nie mozna dodac pustego nawiasa
            listaNapisow.Add("inny napis");
            listaNapisow.Add(hello); //mozna dodac zmienna ktora jest napisem, niekoniecznie sam napis


            hello = "aaa"; //to nie znajduje sie w liscie, bo nie zostało do niej wpakowane

        }

        public void Zadanie2()
        {
            List<KotBezImienia> koty = new List<KotBezImienia>();

            KotBezImienia tom = new KotBezImienia();
            KotBezImienia jerry = new KotBezImienia();

            koty.Add(tom); //pakowanie na listę przez zmienną
            koty.Add(jerry);

            koty.Add(new KotBezImienia()); //pakowanie przez instancję; on nie ma nazwy, jest po prostu na liscie



        }

        public void Zadanie3() //void- pustka, metoda nie zwraca nic
        {
            List<NazwanyKot> koty = new List<NazwanyKot>(); //pomiędzy różnymi metodami zmienne mogą nazywać się tak samo

            NazwanyKot kluska = new NazwanyKot();
            kluska.ImieKota = "Kluska"; //to wynika z propertisa, więc trzeba dać tekst

            koty.Add(kluska);

            NazwanyKot pyza = new NazwanyKot();
            koty.Add(pyza); //kot bez imienia, na razie

            pyza.ImieKota = "Pyza"; //już nazwany

            pyza = new NazwanyKot();
            pyza.ImieKota = "aaa"; //to jest nowa instancja i tego kota juz nie będzie; stara instancja tam nadal jest

            koty.Add(new NazwanyKot());
            koty[2].ImieKota = "Reginio"; //trzeci kot na liscie, ten nei nazwany z linii 58!!!; dopiero tutaj go nazywamy
        }
   



    }
}
