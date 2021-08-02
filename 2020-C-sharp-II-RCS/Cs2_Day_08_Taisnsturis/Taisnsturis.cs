using System;
using System.Collections.Generic;
using System.Text;

namespace Cs2_Day_08_Taisnsturis
{
    class Taisnsturis
    {

            private double Garums { get; set; }
            private double Platums { get; set; }

            public Taisnsturis(double Garums, double Platums)
            {
                this.Garums = Garums;
                this.Platums = Platums;         
            }

            public void PrintInfo()
            {
            Console.WriteLine(Garums * Platums);
            }

    }
}
