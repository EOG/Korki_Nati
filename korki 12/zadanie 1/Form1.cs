﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tekst_TextChanged(object sender, EventArgs e)
        {
            string dodania = tekst.Text;
            checklista.Items.Add(dodania);

        }
    }
}
