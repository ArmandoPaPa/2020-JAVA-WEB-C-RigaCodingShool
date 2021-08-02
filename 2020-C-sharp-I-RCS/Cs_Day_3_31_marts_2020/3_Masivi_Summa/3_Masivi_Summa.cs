using System;

namespace _3_Masivi_Summa
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaitli = { 1, 5, 10, 20, 8, 88, 222, -5 };

            int summa = 0;

            for (int i = 0; i<skaitli.Length; i++)
            {
                if (skaitli[i] > 10)
                    summa += skaitli[i];
            }

            Console.WriteLine($"Skaitlu, kas masiva lielaki par 10 summa ir {summa}");
        }
    }
}
