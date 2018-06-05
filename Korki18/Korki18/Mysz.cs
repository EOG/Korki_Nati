using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korki18
{
    class Mysz
    {
        public int LiczbaPrzyciskow {get; set;}
        
        public void NacisnijPrzycisk(int numerPrzycisku)
        {
            if (this.LiczbaPrzyciskow < numerPrzycisku)
            {
                MessageBox.Show("Nie ma takiego przycisku");
                return; //tutaj kończy się wywołanie funkcji if; z else byłoby tak:
            }
            //else
            //{
            //    MessageBox.Show("Nacisnąłeś " + numerPrzycisku);
            //}
            MessageBox.Show("Nacisnąłeś " + numerPrzycisku);

        }
    }
}
