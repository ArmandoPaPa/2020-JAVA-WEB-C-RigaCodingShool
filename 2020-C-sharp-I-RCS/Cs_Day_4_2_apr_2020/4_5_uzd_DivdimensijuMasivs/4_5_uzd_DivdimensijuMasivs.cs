using System;

namespace _4_5_uzd_DivdimensijuMasivs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divdimensiju masivs");

            int[,] Masivs = new int[5, 4] { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 },
                { 4, 4, 4, 4 }, { 5, 5, 5, 5 } };

            for (int i = 0; i < Masivs.GetLength(0); i++)
            {
                for (int j = 0; j < Masivs.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i}, {j}] = {Masivs[i, j]}");
                }
            }

        }
    }
}
