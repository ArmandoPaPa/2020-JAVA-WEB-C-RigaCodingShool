using System;

namespace _3_CietaisRieksts_Masivi_SamainitVietam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi jebko!");
            string x = Console.ReadLine();
            string y = "";

            for (int i = 0; i<x.Length; i++)
            {
                y += x.Substring(x.Length-1-i,1);
            }

            Console.WriteLine($"Tevis ievaditais no otras puses ir - {y}");
        }
    }
}
