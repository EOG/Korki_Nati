using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korki16
{
    public partial class Form1 : Form
    {
        private List<int> Losuj() //metoda- mówimy JAK COŚ ZROBIĆ a nie kiedy!!!! 
        {
            List<int> wynikLosowania = new List<int>();
            Random random = new Random();
            while (wynikLosowania.Count != 10000)
            { 
                int nowaLiczba = random.Next();
                wynikLosowania.Add(nowaLiczba);
            }
            return wynikLosowania; //musi być return, ponieważ w metodzie nie ma void!!!

        }

        private void PrzydzielDoList(List<int> liczbyDoPrzydzielenia) //metoda; co ma robić a nie kiedy
        {
            //for (int i = 0; i < liczbyDoPrzydzielenia.Count; i++)
            //{
            //    int aktualna = liczbyDoPrzydzielenia[i];
            //}

            foreach (int aktualna in liczbyDoPrzydzielenia) //nie ma [i], po prostu jaka zmienna i w czym
            {
                int reszta = aktualna % 3;
                if (reszta == 0)
                {
                    Przez3.Items.Add(aktualna);
                }

                reszta = aktualna % 5;
                if (reszta == 0)
                {
                    Przez5.Items.Add(aktualna);
                }

                if ((aktualna % 15) == 0)  //% jest operatorem reszty --> WYNIK DZIELENIA PRZEZ 15 = 0; dodatkowy nawias w środku jest niepotrzebny
                {
                    Przez15.Items.Add(aktualna);
                }
            }
        }


        public Form1()  //Form- konstruktor okienka
        {
            InitializeComponent();
            List<int> wylosowaneLiczby = Losuj(); //daj mi listę i nazwij ją wylosowaneLiczby
            PrzydzielDoList(wylosowaneLiczby);
            LiczWyniki();

        }

        private void LiczWyniki()
        {
            iloscWynikow3.Text = Przez3.Items.Count.ToString(); //items- bo to jest kontrolka
            iloscWynikow5.Text = Przez5.Items.Count.ToString();
            iloscWynikow15.Text = Przez15.Items.Count.ToString();
        }

        
    }
}

