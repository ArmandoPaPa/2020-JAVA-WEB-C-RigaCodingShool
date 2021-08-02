using System;

namespace Cs2_Day_05
{
    class Cs2_Day_05_Kalkulators_v01
    {

        // without try catch

        static void Main(string[] args)
        {
            Console.WriteLine("KALKULATORS!");

            Console.Write("Ievadi pirmo skaitli!     ");
            double a = double.Parse(Console.ReadLine());

            string darbiba;

            bool ok = false;

            do
            {
                Console.Write("Kādu darbību Tu vēlies veikt ar šo skaitli?" +
                            "Iespējamās darbības + - * /     ");
                darbiba = Console.ReadLine();

                switch (darbiba)
                {
                    case "+":
                        ok = true;
                        break;
                    case "-":
                        ok = true;
                        break;
                    case "*":
                        ok = true;
                        break;
                    case "/":
                        ok = true;
                        break;
                    default:
                        break;
                }

            } while (ok == false);


            Console.Write("Ievadi otru skaitli!     ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Tavas darbības rezultāts ir =     " + Darbibas.Calc(a, b, darbiba));

        }
    }
}
