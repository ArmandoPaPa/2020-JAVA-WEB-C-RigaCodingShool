using System;

namespace _4_1_uzd_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi, cik vardus velies ievadit - ");
            string skaits = Console.ReadLine();
            int sk_skaits = int.Parse(skaits);

            string[] vardi = new string[sk_skaits];

            int skaititajs = 0;

            do
            {
                Console.Write($"Ievadi {skaititajs + 1}. vardu - ");
                vardi[skaititajs] = Console.ReadLine();
                skaititajs++;
            } while (skaititajs < vardi.Length);

            Console.WriteLine();

            int x = 0;

            Console.WriteLine("Tu ievadiji sekojosus vardus...");
            do
            {
                Console.Write($"{vardi[x]}   ");
                x++;

            } while (x < vardi.Length);


        }
    }
}
