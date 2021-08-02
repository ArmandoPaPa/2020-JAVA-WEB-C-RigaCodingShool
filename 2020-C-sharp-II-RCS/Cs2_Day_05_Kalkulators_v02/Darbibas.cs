using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Cs2_Day_05_Kalkulators_v02
{
    class Darbibas
    {
        public static double Rezultats(double skaitlis1, double skaitlis2, string darbiba)
        {

            double result = 0;

            switch (darbiba)
            {
                case "+":
                    return Saskaitisana(skaitlis1, skaitlis2);
                case "-":
                    return Atnemsana(skaitlis1, skaitlis2);
                case "*":
                    return Reizinasana(skaitlis1, skaitlis2);
                case "/":
                    return Dalisana(skaitlis1, skaitlis2);
                default:
                    return result;
            }
        }

        private static double Saskaitisana(double skaitlis1, double skaitlis2)
        {
            return skaitlis1 + skaitlis2;
        }

        private static double Atnemsana(double skaitlis1, double skaitlis2)
        {
            return skaitlis1 - skaitlis2;
        }

        private static double Reizinasana(double skaitlis1, double skaitlis2)
        {
            return skaitlis1 * skaitlis2;
        }

        private static double Dalisana(double skaitlis1, double skaitlis2)
        {
            return skaitlis1 / skaitlis2;
        }
    }
}
