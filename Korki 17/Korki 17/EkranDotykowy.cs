using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korki_17
{
    class EkranDotykowy
    {
        public void Dotknij(int pozycjaX, int pozycjaY)
        {
            MessageBox.Show("Wybrana pozycja X: " + pozycjaX +  " Y: " + pozycjaY);
            
        }
    }
}
