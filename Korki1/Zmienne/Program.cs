using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaCalkowita = 100;
            int moja = 200;
            int twoja = 300;


            int ujemnaLiczbaCalkowita = -100;

            float liczbaZPrzecinkiem = 100.5f; //może być ujemna

            string text = "Napis ";
            string napisZeZnakiemSpecjalnym  = "Napis \\ <- to jest znak specjalny";

            char znak = 'a';
            char znakSpecjalny = '\'';

            bool wartoscLogicznaFalse = false;
            bool wartoscLogicznaTrue = true;

            Console.Write(liczbaCalkowita + liczbaZPrzecinkiem );

            Console.ReadKey();
        }
    }
}
