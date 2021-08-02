using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;

namespace Cs2_Day_05
{
    class Darbibas
    {
        public static double Calc(double a, double b, string darbiba)
        {
            switch (darbiba)
            {
                case "+":
                    return a+b;
                    
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                
                default:
                    return a / b;
            }
        }
    }
}
