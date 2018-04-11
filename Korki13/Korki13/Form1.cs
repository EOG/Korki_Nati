using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korki13
{
    public partial class Form1 : Form
    {
        //zadeklarowana zmienna w klasie
        List<int> doPosortowania;


        public Form1()
        {
            InitializeComponent();
            doPosortowania = new List<int>()
            {//inicjalizator- jesli nie ma na koncu srednika- tylko dla kolekcji!!!
                //elementy listy piszemy w bloku
                7,3,9,0,1,4
            };
            RysujWynik();
            
        }

        public void RysujWynik()
        {
            string wynikNapis = "";
            //ta petla ma przechodzic przez kazdy element z listy doPosortowania
            for (int i = 0; i < doPosortowania.Count; i++)
            {//do pustego napisu jest dopisany wynik z listy doPosortowania, ale pusty jest tylko na początku
                //wynikNapis = wynikNapis + " " + doPosortowania[i]; --> to samo co w linii nizej, tylko skrocony zapis
                wynikNapis += " " + doPosortowania[i];
            }

            wynik.Text = wynikNapis;
            //wynik.Text- na formularzu--> nasz label na formularzu

        }

        //akcesor: private i public, void- typ zwracany, nic, pusta wartosc, dalej nazwa funkcji
        public void SortowanieBabelkowe(List<int> kolekcja)
        {//pamiętaj!! liczymy od 0
            for (int j = 0; j < kolekcja.Count; j++)
            {
                for (int i = 0; i < kolekcja.Count - j - 1; i++)
                {
                  //  Thread.Sleep(500);
                    Zamien(kolekcja, i, i + 1);
                 //   RysujWynik();
                //    Application.DoEvents();
                }
            }

        }
        public void Zamien(List<int> kolekcja, int i, int j)
        {
            if (kolekcja[i] > kolekcja[j])
                //i to pierwsze czerwone pole, a j to drugie czerwone pole
            {
                int dodatkowa = kolekcja[i];
                kolekcja[i] = kolekcja[j];
                kolekcja[j] = dodatkowa;           

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SortowanieBabelkowe(doPosortowania);

            //quick sort- najszybsza metoda
            //doPosortowania.Sort();
            //doPosortowania.OrderBy(x => x);
            //doPosortowania.OrderByDescending(x => x);

            button1.BackColor = Color.Red;

            RysujWynik();
        }
    }
}
