using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korki18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //    Kalkulator calc = new Kalkulator();
            //    Kalkulator calc1 = new Kalkulator();

            //    float wynik = calc.Dodaj(8, 6.8f);

            //    MessageBox.Show("Wynik dodawania " + calc.Dodaj(5, 6.8f));
            //    MessageBox.Show("Wynik dodawania " + wynik);

            //    //calc.LiczbaWywolan = 4;
            //    calc.LW = 14;
            //    MessageBox.Show("LW: " + calc.LW);

            //    MessageBox.Show("LiczbaWywolan(calc): " + calc.LiczbaWywolan);
            //    MessageBox.Show("LiczbaWywolan(calc1): " + calc1.LiczbaWywolan);

            //    calc.K.Dodaj(6, 7);


            Osoba osoba1 = new Osoba(); //różne instancje klasy, mają własne propertisy, które mają swoje wartości i nie mogą się nimi wymienić--> hermetyzacja
            Osoba osoba2 = new Osoba();

            osoba1.Imie = "Janusz"; //properties działa dokładnie jak zmienna w takim przypadku
            osoba1.Nazwisko = "Nosacz";

            osoba2.Imie = "Grazyna";
            osoba2.Nazwisko = "Ruchała";

            MessageBox.Show(osoba1.Imie  + " " + osoba1.Nazwisko); //SPACJA!!!
            MessageBox.Show(osoba2.Imie + " " + osoba2.Nazwisko);


            ////MessageBox.Show(osoba1.Imie, osoba1.Nazwisko);
            //MessageBox.Show("Czy chcesz do mamy?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


            Mysz mysz = new Mysz();

            mysz.LiczbaPrzyciskow = 2;
            mysz.NacisnijPrzycisk(1);
            mysz.NacisnijPrzycisk(4);


        }
    }
}
