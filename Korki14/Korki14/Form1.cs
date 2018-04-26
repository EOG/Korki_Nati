using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korki14
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        //nieprawdziwie losowy losowacz cyfr, hehe
        public Form1()
        {

            InitializeComponent();

            Matematyka.Nazwa.Text = nameof(Matematyka);
            Fizyka.Nazwa.Text = nameof(Fizyka);
            Informatyka.Nazwa.Text = nameof(Informatyka);

            for (int i = 0; i < 80; i++)
            {
                Matematyka.Oceny.Items.Add(random.Next(1, 6));
                Fizyka.Oceny.Items.Add(random.Next(1, 6));
                Informatyka.Oceny.Items.Add(random.Next(1, 6));
                //przedzial, random.Next zwraca JEDNA cyfre, a nie wiele! dlatego jest petla. W przedziale wlacznie od 1 wykluczajac 6 (od 1 do 6 bez 6)
            }

            //Przedmiot.Oceny.Items - zawiera oceny z przedmiotu
            //Przedmiot.Oceny.Items.Count - zawiera liczbę ocen
            //Przedmiot.Srednia.Text - tu wpisuje tu wpisujesz średnią
            //Przedmiot.Najlepsza.Text - tu wpisujesz najlepszą ocenę

            ObliczSrednia();
            ObliczNajlepsza();
            //SzybkaSrednia();
            //SzybkaMax();
        }

        public void SzybkaSrednia()
        {
            Matematyka.Srednia.Text = Matematyka.Oceny.Items.OfType<int>().Average().ToString();
            Fizyka.Srednia.Text = Fizyka.Oceny.Items.OfType<int>().Average().ToString();
            Informatyka.Srednia.Text = Informatyka.Oceny.Items.OfType<int>().Average().ToString();
        }

        public void SzybkaMax()
        {
            Matematyka.Najlepsza.Text = Matematyka.Oceny.Items.OfType<int>().Max().ToString();
            Fizyka.Najlepsza.Text = Fizyka.Oceny.Items.OfType<int>().Max().ToString();
            Informatyka.Najlepsza.Text = Informatyka.Oceny.Items.OfType<int>().Max().ToString();
        }

        public void ObliczSrednia()
        {
            float suma = 0;
            for (int i = 0; i < Matematyka.Oceny.Items.Count; i++)
            {
                suma = suma + (int)Matematyka.Oceny.Items[i];
            }
            Matematyka.Srednia.Text = (suma / Matematyka.Oceny.Items.Count).ToString();


            suma = 0;
            for (int i = 0; i < Fizyka.Oceny.Items.Count; i++)
            {
                suma = suma + (int)Fizyka.Oceny.Items[i];
            }
            Fizyka.Srednia.Text = (suma / Fizyka.Oceny.Items.Count).ToString();


            suma = 0;
            for (int i = 0; i < Informatyka.Oceny.Items.Count; i++)
            {
                suma = suma + (int)Informatyka.Oceny.Items[i];
            }
            Informatyka.Srednia.Text = (suma / Informatyka.Oceny.Items.Count).ToString();
        }


        public void ObliczNajlepsza()
        {
            int najwyzsza = 0;
            for (int i = 0; i < Matematyka.Oceny.Items.Count; i++)
            {
                int ocenaZListy = (int)Matematyka.Oceny.Items[i];
                //(int) na poczatku - mowimy mu ze to jest cyfra - przekonwertowanie
                if (najwyzsza < ocenaZListy)
                {
                    najwyzsza = ocenaZListy;
                }
            }
            Matematyka.Najlepsza.Text = najwyzsza.ToString();


            najwyzsza = 0;
            for (int i = 0; i < Fizyka.Oceny.Items.Count; i++)
            {
                int ocenaZListy = (int)Fizyka.Oceny.Items[i];
                if (najwyzsza < ocenaZListy)
                {
                    najwyzsza = ocenaZListy;
                }
            }
            Fizyka.Najlepsza.Text = najwyzsza.ToString();



            najwyzsza = 0;
            for (int i = 0; i < Informatyka.Oceny.Items.Count; i++)
            {
                int ocenaZListy = (int)Informatyka.Oceny.Items[i];              
                if (najwyzsza < ocenaZListy)
                {
                    najwyzsza = ocenaZListy;
                }
            }
            Informatyka.Najlepsza.Text = najwyzsza.ToString();

        }

    }
}
