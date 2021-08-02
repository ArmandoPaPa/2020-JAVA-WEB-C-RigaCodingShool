using System;

namespace _1_3_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi savu vardu");

            string vards = Console.ReadLine();

            Console.WriteLine("Ievadi savu uzvardu");

            string uzvards = Console.ReadLine();

            Console.WriteLine($"Tevi sauc {vards} {uzvards} vai saisinajuma {vards.Substring(0, 1)}.{uzvards}.");
        }
    }
}
