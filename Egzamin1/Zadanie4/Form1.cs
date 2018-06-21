using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Piłka doNogi = new Piłka();
            doNogi.Nazwa = "Piłka do nogi";

            Piłka doKosza = new Piłka();
            doKosza.Nazwa = "Piłka do kosza";

            Piłka doRugby = new Piłka();
            doRugby.Nazwa = "Piłka do Rugby";


        }
    }
}
