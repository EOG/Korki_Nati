using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korki_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            Klawiatura klawiatura = new Klawiatura();
            klawiatura.NacisnijPrzycisk("Message");


            Mysz mysz = new Mysz();
            mysz.NacisnijLewy();
            mysz.NacisnijPrawy();

            Joystick joystick = new Joystick();
            joystick.Galka(0);
            joystick.Galka(1);
            joystick.Galka(2);
            joystick.Galka(3);
            joystick.Galka(150);

            joystick.NacisnietePrzyciski(true, true);

            EkranDotykowy ekran = new EkranDotykowy();
            ekran.Dotknij(50,90);


        }

    }
}
