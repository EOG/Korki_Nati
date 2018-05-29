using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //to musi byc aby wiedzial o co chodzi z MessageBox

namespace Korki_17
{
    class Klawiatura
    {
        public void NacisnijPrzycisk(string kodPrzycisku)
        {
           MessageBox.Show("Nacisnales " + kodPrzycisku); //to wynika z using System...itd.
           
        }
    }
}
