using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korki_17
{
    class Mysz
    {
        public void NacisnijLewy() //Nie ma tu argumentu ani zadnych kodow przycisku (jak dla klawiatury), parametrow. bo to zwykla MYSZ
        {
            MessageBox.Show("Nacisnales lewy przycisk");

        }

        public void NacisnijPrawy()
        {
            MessageBox.Show("Nacisnales prawy przycisk");
        }
    }
}
