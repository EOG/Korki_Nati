using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PFTest.Core;

namespace PFTest
{
    class MyApp : App
    {
        const int LEVEL = 2;

        protected override Map map => levels[LEVEL];

        protected override void Movement()
        {

            int lkrokow = 0;
            while (lkrokow < 7)
            {

                for (int a = 0; a < lkrokow + 1; a++)
                {
                    User.Go();
                }
                lkrokow++;
                User.RotateLeft();
            }
            User.RotateLeft();

            int lkrokow2 = lkrokow;
            while (lkrokow2 > 0)
            {

                for (int a = 0; a < lkrokow2; a++)
                {
                    User.Go();
                }
                lkrokow2--;
                User.RotateRight();
            }

            
        }

        //zad3
        //protected override void Movement()
        //{
        //        int s = 0;
        //        while (s < 4) 
        //    {
        //        s++;
        //        User.RotateRight();
        //        User.Go();
        //        User.Go();
        //    }

        //    User.RotateLeft();
        //    User.RotateLeft();

        //    for (int v = 0; v < 4; v++) 
        //    {            
        //        User.Go();
        //        User.Go();
        //        User.RotateLeft();
        //    }

        //}







        //protected override void Movement()
        //{
        //   User.RotateRight();

        //    int x = 0;
        //    while (x<101)

        //    {
        //        x++;
        //        int n = 1;
        //        while (n <= 7)
        //        {
        //            n++;
        //            User.Go();
        //        }

        //        int m = 1;
        //        while (m <= 2)
        //        {
        //            m++;
        //            User.RotateRight();
        //        }
        //    }
        //}

        //zad1
        //protected override void Movement()
        //{
        //    User.RotateRight();

        //    int n = 1;
        //    while (n <= 7)
        //    {
        //        n++;
        //        User.Go();
        //    }

        //    int m = 1;
        //    while (m <= 4)
        //    {
        //        m++;
        //        User.RotateRight();
        //    }


        //    User.Go();

        //}



        List<Map> levels = new List<Map>()
        {
            new Map(new Point(1, 3), new int[,]
                {
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                }),
            new Map(new Point(1, 1), new int[5, 5]
                {
                    { 1, 1, 1, 1, 1 },
                    { 1, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 1 },
                    { 1, 1, 1, 1, 1 },
                }),
            new Map(new Point(5, 4), new int[,]
                {
                    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                    { 1, 0, 1, 1, 1, 1, 1, 0, 1, 0 },
                    { 1, 0, 1, 0, 0, 0, 1, 0, 1, 0 },
                    { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                    { 1, 0, 1, 0, 1, 1, 1, 0, 1, 0 },
                    { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0 },
                    { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                }),
            new Map(new Point(1, 8), new int[,]
                {
                    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                    { 1, 0, 1, 1, 1, 1, 1, 0, 1, 0 },
                    { 1, 0, 1, 0, 0, 0, 1, 0, 1, 0 },
                    { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                    { 1, 0, 1, 0, 1, 1, 1, 0, 1, 0 },
                    { 1, 0, 1, 0, 0, 0, 0, 0, 1, 0 },
                    { 1, 0, 1, 1, 1, 1, 1, 1, 1, 0 },
                    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                }),
        };
    }
}
