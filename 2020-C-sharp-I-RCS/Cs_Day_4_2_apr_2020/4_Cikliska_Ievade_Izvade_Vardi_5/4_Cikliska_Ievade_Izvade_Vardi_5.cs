using System;

namespace _4_Cikliska_Ievade_Izvade_Vardi_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi, cik vardus velesies ievadit MASIVA?   ");
            string Skaits = Console.ReadLine();
            int x = int.Parse(Skaits);

            string[] vardi = new string[x];

            for (int i = 0; i < vardi.Length; i++)
            {
                Console.Write($"Ievadi {i + 1}.vardu - ");
                vardi[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Vardi, kuros ir 5 un vairak burti, ir sekojosi:");

            for (int i = 0; i < vardi.Length; i++)
            {
                if (vardi[i].Length >= 5)
                {
                    Console.WriteLine(vardi[i]);
                }
            }

        }
    }
}
