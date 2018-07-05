using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziennikZKonstruktorem
{
    public class PrzedmiotZKonstruktorem
    {
        public string NazwaPrzedmiotu { get; set; } //musi byc properties bo potem jest konstruktor

        public PrzedmiotZKonstruktorem() //to jest domyślny kontruktor- każda klasa ma taki kontruktor, nawet jeśli się go nie napisze
        {

        }

        public PrzedmiotZKonstruktorem(string nazwa) //żaden konstruktor nie ma typu zwracanego czyli void. int, string itd.
        {
            this.NazwaPrzedmiotu = nazwa; //this to to samo co instancja, ponadto this powiązuje properties i konstruktor!!!
            
        }
    }
}
