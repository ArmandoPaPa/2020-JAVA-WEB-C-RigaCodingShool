using System;

namespace _3_4_uzd_Masivs_SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cik vardus Tu Velies ievadit masiva? Ievadi skaitli!");

            string x = Console.ReadLine();
            int V_sk = int.Parse(x);

            string[] vardi = new string[V_sk];

            for (int i = 0; i < V_sk; i++)
            {
                Console.WriteLine("Aizpildi masivu - IEVADI VARDU!");
                vardi[i] = Console.ReadLine();
            }

            Console.WriteLine("Tu ievadiji sekojosus vardus!");

            for (int i = 0; i < V_sk; i++)
            {
                Console.Write($"{vardi[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Ar burtu 'J' masiva ir sekojosi vardi");

            for (int i = 0; i < V_sk; i++)
            {
                if (vardi[i].Substring(0, 1) == "J")
                {
                    Console.Write($"{vardi[i]}   ");
                }
            }
        }
    }
}
