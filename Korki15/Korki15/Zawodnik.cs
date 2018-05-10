using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korki15
{
    public partial class Zawodnik : UserControl
    {
        public Zawodnik()
        {
            InitializeComponent();
        }

        public int Pozyzja
        {
            get
            {
                return this.Location.X;
            }
            set
            {
                this.Location = new Point(value, this.Location.Y);
            }
        }
    }
}
