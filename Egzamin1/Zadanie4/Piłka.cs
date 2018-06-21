using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie4
{
    class Piłka
    {
        public string Nazwa;
        public float Srednica;
        public bool Pump = false;

        public void Napompuj()
        {
            Pump = true;
        }


    }
}
