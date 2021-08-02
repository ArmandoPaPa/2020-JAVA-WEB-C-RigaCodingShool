using System;

namespace _2_CietaisRieksts_Reizrekins_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi skaitli!   ");
            string skaitlis = Console.ReadLine();

            int x = int.Parse(skaitlis);

            if (x > 20)
            {
                Console.WriteLine("Skaitlis ir par LIELU!");
            }

            else
            {
                int n = 1;

                int reizinajums = 0;

                while (n <= x)
                {
                    if (n <= 5)
                    {
                        reizinajums = x * n;
                        Console.Write($"{reizinajums}   ");
                        n++;
                    }

                    if (n==6)
                    {
                        Console.WriteLine();
                    }

                    if (n > 5 && n <= 10)
                    {
                        reizinajums = x * n;
                        Console.Write($"{reizinajums}   ");
                        n++;
                    }

                    if (n == 11)
                    {
                        Console.WriteLine();
                    }

                    if (n > 10 && n <= 15)
                    {
                        reizinajums = x * n;
                        Console.Write($"{reizinajums}   ");
                        n++;
                    }

                    if (n == 16)
                    {
                        Console.WriteLine();
                    }

                    if (n > 15 && n <= 20)
                    {
                        reizinajums = x * n;
                        Console.Write($"{reizinajums}   ");
                        n++;
                    }
                    

                }


            }
        }
    }
}

