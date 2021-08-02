using System;

namespace _4_2_uzd_TukssMasivs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tev vajadzes ievadit 10 skaitlus!");

            int[] skaitli = new int[10];

            for (int i = 0; i < skaitli.Length; i++)
            {
                Console.Write($"Ievadi {i + 1}. skaitli - ");
                string ievade = Console.ReadLine();

                skaitli[i] = int.Parse(ievade);
            }

            Console.WriteLine("Tu ievadiji sekojosus skaitlus...");

            for (int j = 0; j < skaitli.Length; j++)
            {
                Console.Write($"{skaitli[j]}   ");
            }
        }
    }
}
