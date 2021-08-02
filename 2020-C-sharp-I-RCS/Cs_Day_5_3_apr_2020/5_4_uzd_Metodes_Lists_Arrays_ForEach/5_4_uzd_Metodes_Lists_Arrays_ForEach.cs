using System;
using System.Collections.Generic;

namespace _5_4_uzd_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cipari = new List<int> { 10, 20, 30, 40, 50 };

            List<string> vardi = new List<string> { "aaa", "bbb", "ccc", "ddd", "eee" };

            int[] cipari2 = new int[] { 111, 222, 333, 444, 555 };

            string[] vardi2 = new string[] { "AAA", "BBB", "CCC", "DDD", "EEE" };

            PrintArrayValues(cipari);
            Console.WriteLine();

            PrintArrayValues(vardi);
            Console.WriteLine();

            PrintArrayValues(cipari2);
            Console.WriteLine();

            PrintArrayValues(vardi2);
            Console.WriteLine();
        }

        static void PrintArrayValues(List<int> cipari)
        {
            foreach (int x in cipari)
            {
                Console.Write($"{x}   ");
            }
        }

        static void PrintArrayValues(List<string> vardi)
        {
            foreach (string x in vardi)
            {
                Console.Write($"{x}   ");
            }
        }

        static void PrintArrayValues(int[] cipari2)
        {
            foreach (int x in cipari2)
            {
                Console.Write($"{x}   ");
            }
        }

        static void PrintArrayValues(string[] vardi2)
        {
            foreach (string x in vardi2)
            {
                Console.Write($"{x}   ");
            }
        }
    }
}
