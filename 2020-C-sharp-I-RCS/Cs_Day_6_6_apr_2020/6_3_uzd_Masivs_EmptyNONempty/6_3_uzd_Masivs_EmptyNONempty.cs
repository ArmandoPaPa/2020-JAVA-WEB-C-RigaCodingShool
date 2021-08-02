using System;

namespace _6_3_uzd_Masivs_EmptyNONempty
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vardi = { "Jānis", "", "Pēteris", "Antons", "", "Andris" };

            PrintArrayValues(vardi);

            Console.WriteLine();

            GetNonEmtyArray(vardi);

        }

        static void GetNonEmtyArray(string[] vardi)
        {
            int n = 0;

            for (int i = 0; i < vardi.Length; i++)
            {
                if (!string.IsNullOrEmpty(vardi[i]))
                {
                    n++;
                }
            }

            string[] vardiBEZtuksumiem = new string[n];

            int skaititajs = 0;

            for (int i = 0; i < vardi.Length; i++)
            {
                if (!string.IsNullOrEmpty(vardi[i]))
                {
                    vardiBEZtuksumiem[skaititajs] = vardi[i];
                    skaititajs++;
                }
            }

            PrintArrayValues(vardiBEZtuksumiem);

        }

        static void PrintArrayValues(string[] vardi)
        {
            foreach (var item in vardi)
            {
                Console.Write($"[ {item} ]-");
            }
        }

    }
}
