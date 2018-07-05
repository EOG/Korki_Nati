using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziennikZKonstruktorem
{
    public class UczenZKonstruktorem
    {
        public string ImieUcznia { get; set; }
        public List<PrzedmiotZKonstruktorem> ListaPrzedmiotow {get;set;}


        public UczenZKonstruktorem(string imie, string nazwisko)
        {
            //this.ImieUcznia = imie + " " + nazwisko;
            this.ImieUcznia = $"{imie} {nazwisko}"; //to jest to samo co w linii 17

            this.ListaPrzedmiotow = new List<PrzedmiotZKonstruktorem>(); //bo properties na początku nie ma wartości- to jest nadanie wartosci propertisowi czyli nowa lista
            
        }



    }


    
}
