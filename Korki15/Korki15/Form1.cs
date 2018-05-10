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

namespace Korki15
{
    public partial class Form1 : Form
    {
        //To nie jest ważne u pomocnik rysowania, narazie zapomnij!!!! o tej metodzie
        private void timer1_Tick(object sender, EventArgs e)
        {
            Update();
        }

        private void AudioPlayer_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
        }


        public Form1()
        {
            InitializeComponent();
            

            AudioPlayer.RunWorkerAsync();

        }
        Random Predkosc = new Random();  //randomowa predkosc
        public void Update()   //metoda do przesuwania zawodnikow co kilka ms (by Piotr)
        {
            zawodnik1.Pozyzja += Predkosc.Next(7, 12);
            zawodnik2.Pozyzja += Predkosc.Next(7, 12);
            zawodnik3.Pozyzja += Predkosc.Next(7, 12);

            if (zawodnik1.Pozyzja > Meta.Location.X)    //Location ma X i Y--> współrzędne w ramce Form
            {
                wyscig.Stop();
                MessageBox.Show("Koniec");
                if(Zaklad1.Checked == true)
                {
                    MessageBox.Show("Wygrałeś!");
                }
                else
                {
                    MessageBox.Show("Przegrałeś :(");
                }
            }
            else if (zawodnik2.Pozyzja > Meta.Location.X)
            {
                wyscig.Stop();
                MessageBox.Show("Koniec");
                if (Zaklad2.Checked == true)
                {
                    MessageBox.Show("Wygrałeś!");
                }
                else
                {
                    MessageBox.Show("Przegrałeś :(");
                }

            }
            else if (zawodnik3.Pozyzja > Meta.Location.X)
            {
                wyscig.Stop();
                MessageBox.Show("Koniec");
                if (Zaklad3.Checked == true)
                {
                    MessageBox.Show("Wygrałeś!");
                }
                else
                {
                    MessageBox.Show("Przegrałeś :(");
                }

            }
            //if (zawodnik1.Pozyzja > Meta.Location.X || zawodnik2.Pozyzja > Meta.Location.X || zawodnik3.Pozyzja > Meta.Location.X)
            //{
            //    wyscig.Stop();
            //    MessageBox.Show("Koniec");
            //}
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //if (Zaklad1.Checked == false)    //"checked" to jak dla obiektow z listy "items"! Tutaj chodzi o zaznaczanie kóleczkiem
            //{
            //    if (Zaklad2.Checked == false)
            //    {
            //        if (Zaklad3.Checked == false)                      
            //        {
            //            MessageBox.Show("Nie zaznaczyłeś zakładu! Zaznacz zakład aby rozpocząć.");
            //        }
            //    }
            //}
            if (Zaklad1.Checked == false && Zaklad2.Checked==false && Zaklad3.Checked==false)
            {
                MessageBox.Show("Nie zaznaczyłeś zakładu! Zaznacz zakład aby rozpocząć.");
            } 
            else
            {
                wyscig.Start(); //metoda do rozpoczęcia wyścigu
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wyscig.Stop();
            zawodnik1.Pozyzja = 35;
            zawodnik2.Pozyzja = 35;
            zawodnik3.Pozyzja = 35;
        }
    }
}
