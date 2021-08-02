using System;

namespace _5_2_uzd_Metodes_ar_parametriem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi savu vardu - ");
            string Vards = Console.ReadLine();

            Console.Write("Ievadi savu uzvardu - ");
            string Uzvards = Console.ReadLine();

            Console.WriteLine();

            PrintMyName(Vards, Uzvards);

            Console.WriteLine(PrintMyName_RETURN(Vards, Uzvards));
        }

        static void PrintMyName(string Vards, string Uzvards)
        {
            string VardaBurts = Vards.Substring(0, 1);

            Console.WriteLine($"{VardaBurts}. {Uzvards}");
        }

        static string PrintMyName_RETURN(string Vards, string Uzvards)
        {
            string VardaBurts = Vards.Substring(0, 1);

            return VardaBurts + ". " + Uzvards;
        }

    }
}
