using System;

namespace _4_4_uzd_SkaitluRobezas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaitli = { 1, 56, 77, 89, 34, 22, 2, 3, 4, 8, 43, 56 };

            Console.WriteLine("Robezas 0-30 ir sekojosi skaitli:");
            for (int i = 0; i < skaitli.Length; i++)
            {
                if (skaitli[i] >= 0 && skaitli[i] <= 30)
                {
                    Console.Write($"{skaitli[i]}   ");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Robezas 31-60 ir sekojosi skaitli:");
            for (int i = 0; i < skaitli.Length; i++)
            {
                if (skaitli[i] >= 31 && skaitli[i] <= 60)
                {
                    Console.Write($"{skaitli[i]}   ");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Robezas 61-90 ir sekojosi skaitli:");
            for (int i = 0; i < skaitli.Length; i++)
            {
                if (skaitli[i] >= 61 && skaitli[i] <= 90)
                {
                    Console.Write($"{skaitli[i]}   ");
                }
            }
        }
    }
}
