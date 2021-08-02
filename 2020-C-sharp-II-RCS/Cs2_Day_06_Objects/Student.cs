using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Cs2_Day_06_Objects
{
    class Student
    {
        /*
                1) Uztaisīt studentu klasi.
                Klasē jābūt- vārds, uzvārds, kurss.
                Kursam ir jāpārbauda vai vērtība ir no 1 - 3 ieskaitot, 
                ja ir vairāk par 3, tad piešķiram 3, ja mazāk par 1, tad piešķiram 1. 

                2) Publisku metodi PrintInfo()

                3) Vērtības(vārdu, uzvārdu un kursu ievada lietotājs)
             
         */

        public String vards { get; set; }
        public String uzvards { get; set; }

        private int kurss;
        public void kursaParbaude(int kursaIevade)
        {
            if (kursaIevade <= 1)
            {
                kurss = 1;
            }
            else if (kursaIevade > 1 && kursaIevade < 3)
            {
                kurss = kursaIevade;
            }
            else
            {
                kurss = 3;
            }
        }

        public int getKurss()
        {
            return kurss;
        }

        public void PrintInfo()
        {
            Console.WriteLine(vards + " " + uzvards + " " + kurss + ". kurss!");
        }


    }
}
