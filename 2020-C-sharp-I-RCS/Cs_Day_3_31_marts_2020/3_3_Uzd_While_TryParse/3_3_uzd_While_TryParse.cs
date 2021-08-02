using System;

namespace _3_3_Uzd_While_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool NESkaitlis;
            int x;

            do
            {
                Console.WriteLine("Ievadi veselu skaitli!");
                string Sk = Console.ReadLine();

                NESkaitlis = int.TryParse(Sk, out x);

            } while (!NESkaitlis);

            Console.WriteLine($"Tu ievadiji skaitli {x}");


        }
    }
}
