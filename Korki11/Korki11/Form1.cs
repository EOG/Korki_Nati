using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korki11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void przenies_Click(object sender, EventArgs e)
        {
            

           // for (int i = 0; i < lewa.Items.Count; i++) 
            {
               // MessageBox.Show(lewa.Items[i].ToString());
            }
            
            for (int i = 0; i< lewa.CheckedItems.Count; i++)
            {
                //MessageBox.Show(lewa.CheckedItems[i].ToString());
                prawa.Items.Add(lewa.CheckedItems[i].ToString());

            }
            //lewa.Items.RemoveAt(0);

            //for (int i = 0; i < lewa.CheckedItems.Count;) 
            //{
            //    lewa.Items.Remove(lewa.CheckedItems[i]);
            //}

            while (lewa.CheckedItems.Count != 0)
            {
                lewa.Items.Remove(lewa.CheckedItems[0]);
            }

        }

        private void odprzenies_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < prawa.CheckedItems.Count; i++)
            {
                lewa.Items.Add(prawa.CheckedItems[i]);
            }

            for (int i = 0; i < prawa.CheckedItems.Count;)
            {
                prawa.Items.Remove(prawa.CheckedItems[0]);
            }
        }
    }
}
