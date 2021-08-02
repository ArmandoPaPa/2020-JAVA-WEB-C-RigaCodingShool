using System;

namespace _3_Masivi_MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi, cik skaitlus tu velies MASIVA?   ");
            string Garums = Console.ReadLine();
            int G = int.Parse(Garums);

            int[] MinMaxMASIVS = new int[G];
            string[] MasivsStringa = new string[G];

            for (int i = 0; i < MinMaxMASIVS.Length; i++)
            {
                Console.Write("Ievadi masiva Skaitli   ");
                MasivsStringa[i] = Console.ReadLine();
                MinMaxMASIVS[i] = int.Parse(MasivsStringa[i]);
            }
            for (int i = 0; i < MinMaxMASIVS.Length; i++)
            {
                Console.Write($"{MinMaxMASIVS[i]}   ");
            }

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < MinMaxMASIVS.Length; i++)
            {
                if (MinMaxMASIVS[i] < min)
                {
                    min = MinMaxMASIVS[i];
                }
            }

            Console.WriteLine();

            Console.WriteLine($"Masiva minimala vertiba ir {min}");

            for (int i = 0; i < MinMaxMASIVS.Length; i++)
            {
                if (MinMaxMASIVS[i] > max)
                {
                    max = MinMaxMASIVS[i];
                }
            }

            Console.WriteLine($"Masiva maksimala vertiba ir {max}");
        }
    }
}
