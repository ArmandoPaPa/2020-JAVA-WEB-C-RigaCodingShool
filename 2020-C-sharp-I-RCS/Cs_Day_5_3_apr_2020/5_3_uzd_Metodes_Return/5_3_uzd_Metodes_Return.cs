using System;

namespace _5_3_uzd_Metodes_Return
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName(GetName());
        }

        static string GetName()
        {
            Console.Write("Ievadi savu vardu - ");
            string vards = Console.ReadLine();
            return vards;
        }

        static void PrintName(string vards)
        {
            Console.WriteLine(vards);
        }

    }
}
