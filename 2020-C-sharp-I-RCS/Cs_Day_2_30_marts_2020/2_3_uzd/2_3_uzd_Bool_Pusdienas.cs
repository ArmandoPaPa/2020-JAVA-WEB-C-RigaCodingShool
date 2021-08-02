using System;

namespace _2_3_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("PUSDIENAS! Dargais draugs, vai tu velies pusdienas?" +
                " Ievadi TRUE, ja velies, un FALSE, ja nevelies!   ");
            string a = Console.ReadLine();

            bool pusdienas = bool.Parse(a);

            if (pusdienas)
            {
                Console.WriteLine("Jusu pusdienas ir gatavas!");
            }
            else if (!pusdienas)
            {
                Console.WriteLine("Jums pusdienas nebus!");
            }
        }
    }
}
