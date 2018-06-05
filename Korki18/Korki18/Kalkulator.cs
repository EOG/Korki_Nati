using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  //tylko do Message boxów

namespace Korki18
{
    class Kalkulator 
    {
        public int LiczbaWywolan { get; private set; }  
        public int LW;

        public Kalkulator K;

        public float Dodaj(float x, float y)
        {
            LiczbaWywolan++;
            LW++;
            return x + y;
        }

        public float  Odejmij (float x, float y) //metody sa od siebie niezależne, więc zawsze trzeba dopisać public float!
        {
            return x - y;

        }
        public float Podziel (float x, float y)
        {
            if (y==0)
            {
                return 0;
            }

            return x / y;

        }

        public float Pomnoz (float x, float y)
        {
            return x * y;
        }
    }
}
