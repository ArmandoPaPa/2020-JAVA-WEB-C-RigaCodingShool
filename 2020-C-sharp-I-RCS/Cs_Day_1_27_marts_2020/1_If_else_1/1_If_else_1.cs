using System;

namespace _1_If_else_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi jebkuru skaitli!");

            string Str_skaitlis = Console.ReadLine();

            double skaitlis = double.Parse(Str_skaitlis);

            if (skaitlis >= 0 && skaitlis <= 10)
            {
                Console.WriteLine("A"); ;
            }
            else if (skaitlis > 10)
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("Tu ievadiji skaitli mazaku par 0");
            }

        }
    }
}