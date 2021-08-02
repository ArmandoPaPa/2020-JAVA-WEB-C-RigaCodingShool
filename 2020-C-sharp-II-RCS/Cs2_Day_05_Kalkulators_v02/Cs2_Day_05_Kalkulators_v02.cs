using System;

namespace Cs2_Day_05_Kalkulators_v02
{
    class Cs2_Day_05_Kalkulators_v02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi 1. skaitli!     ");
            double skaitlis1 = SkaitlaIevade();

            Console.WriteLine();
            Console.WriteLine();

            string darbiba;
            do
            {
                Console.WriteLine("Kādu darbību Tu vēlies veikt + - * /    ");
                darbiba = Console.ReadLine();
            } while (!darbiba.Equals("+") && !darbiba.Equals("-")
                    && !darbiba.Equals("*") && !darbiba.Equals("/"));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ievadi 2. skaitli!     ");
            double skaitlis2 = SkaitlaIevade();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(skaitlis1 + "   "  + darbiba + "   "  + skaitlis2 + "    =    "
                + Darbibas.Rezultats(skaitlis1, skaitlis2, darbiba));

        }

        public static double SkaitlaIevade()
        {
            double skaitlis;
            try
            {
                Console.Write("Ievadi skaitli!   ");
                skaitlis = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                skaitlis = SkaitlaIevade();
            }
            return skaitlis;
        }
    }
}
