using System;

namespace _2_Kalkulators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KALKULATORS");

            Console.Write("Ievadi 1. skaitli   ");
            string a = Console.ReadLine();

            Console.Write("Ievadi 2. skaitli   ");
            string b = Console.ReadLine();

            double a_sk = double.Parse(a);
            double b_sk = double.Parse(b);

            Console.Write("Ievadi, kadu aritmetisko darbibu ( + - * / ) velies veikt ar ievaditajiem " +
                "skaitliem   ");

            string darbiba = Console.ReadLine();

            switch (darbiba)
            {
                case "+":
                    Console.WriteLine($"Tevis ievadito skaitlu {a_sk} un {b_sk} summa ir {a_sk + b_sk}");
                    break;
                case "-":
                    Console.WriteLine($"Tevis ievadito skaitlu {a_sk} un {b_sk} starpiba ir {a_sk - b_sk}");
                    break;
                case "*":
                    Console.WriteLine($"Tevis ievadito skaitlu {a_sk} un {b_sk} reizinajums ir {a_sk * b_sk}");
                    break;
                case "/":
                    Console.WriteLine($"Tevis ievadito skaitlu {a_sk} un {b_sk} dalijums ir {a_sk / b_sk}");
                    break;

                default:
                    break;
            }
        }
    }
}
