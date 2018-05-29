using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korki_17
{
    class Joystick
    {
        public void Galka(int kierunek)
        {
            if (kierunek == 0) 
            {
                MessageBox.Show("Przesun w gore");                        //kliknac na MessageBox i ctrl+kropka--> wybra c windows.forms-->nie trzeba dopisywac
            }

            else if(kierunek == 1)
            {
                MessageBox.Show("Przesun w prawo");
            }

            else if (kierunek == 2)
            {
                MessageBox.Show("Przesun w dol");
            }

            else if(kierunek ==3)
            {
                MessageBox.Show("Przesun w lewo");
            }

            else
            {
                MessageBox.Show("Lol, co?");
            }

        }

        public void NacisnietePrzyciski(bool pierwszyPrzcisk, bool drugiPrzycisk)
        {
            if (pierwszyPrzcisk)        //z gory zaklada ze boie wartosci sa mozliwe; dopiero przy dopisaniu true lub false nastapilaby reakcja
            {
                MessageBox.Show("Nacisnąłeś pierwszy przycisk");
            }

            if (drugiPrzycisk)
            {
                MessageBox.Show("Nacisnąłeś drugi przycisk");
            }
        }


    }
}
