using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_z_pilka
{
    class Pilka
    {
        public string Nazwa { get; set; }   //jeśli get i set są puste, to properties zachowuje się jak zmienna!

        public float Srednica { get; set; }

        public bool Pump { get; set; }

        public bool Napompuj()  //definicja
        {
            this.Pump = true;    //to co w bloku to cialo metody
            return this.Pump;
        }


        public void UstawNazwe(string nowaNazwa) //definicja metody
        {
            this.Nazwa = nowaNazwa; //this to nasza noga, x i y !!!!!!!!!!!!!!!!!!!!!!!!

            this.Srednica = 10;
        }

        

    }
}
