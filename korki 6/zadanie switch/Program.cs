﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string odpowiedz = Console.ReadLine();

                if (odpowiedz == "mario")
                {
                    Console.WriteLine("odyssey");
                }

                else if (odpowiedz == "splatoon")
                {
                    Console.WriteLine("ink");
                }

                else if (odpowiedz == "bayonetta")
                {
                    Console.WriteLine("witch");
                }

                else if (odpowiedz == "syberia")
                {
                    Console.WriteLine("snow");
                }

                else if (odpowiedz == "rime")
                {
                    Console.WriteLine("snow");
                }

                else
                {
                    Console.WriteLine("doom");
                }


                switch (odpowiedz)
                {
                    case "mario":
                        Console.WriteLine("odyssey");
                        break;

                    case "bayonetta":
                        Console.WriteLine("witch");
                        break;

                    case "syberia":
                    case "rime":
                        Console.WriteLine("snow");
                        break;

                    default:
                        Console.WriteLine("doom");
                        break;
                }

            }
            Console.ReadKey();
        }


    }
}
