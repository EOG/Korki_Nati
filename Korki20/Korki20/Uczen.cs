using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korki20
{
    public class Uczen //klasa jako public aby można było zaciągać dane w inne miejsca
    {
        public string Name { get; set; }
        public List<Przedmiot> ListaPrzedmiotow { get; set; }  //przedmiot jest juz zadeklarowany, wiec mozna go tu uzyc
    }
}
