using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace korki_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Dodajprodukt_Click(object sender, EventArgs e)
        {
            string dododania = Produkt.Text;
            Listazakupow.Items.Add(dododania);
            Produkt.Text="";
        }

        private void zapisz_Click(object sender, EventArgs e)
        {

            //File.WriteAllText("mojplik.txt", "pomoz bo ja nie wiem");
            //File.WriteAllText("plikpiotra", "monika co sie smiejesz");
            //File.WriteAllText("plikadobe.pdf", "dziekujmy za adobe");


            List<string> bazadanych = new List<string>();
            for (int index = 0; index < Listazakupow.Items.Count; index++)
            {
                bazadanych.Add(Listazakupow.Items[index].ToString());
            }
            File.WriteAllLines("zakupy", bazadanych);
            MessageBox.Show("Zapisano");
        }

        private void wczytaj_Click(object sender, EventArgs e)
        {
            List<string> bazadanych = File.ReadAllLines("zakupy").ToList();
            for (int index = 0; index < bazadanych.Count; index++)
            {
                Listazakupow.Items.Add(bazadanych[index]);
            }
        }
    }
}
