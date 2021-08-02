using System;

namespace _2_CietaisRieksts_Reizrekins_WHILE_FINAL
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
                int RR;

                int HORIZ = 1;

                int VERT = 1;

                while (VERT <= x)
                {
                    while (HORIZ <= x)
                    {
                        RR = HORIZ * VERT;
                        Console.Write($"{RR}  ");
                        HORIZ++;
                    }
                    Console.WriteLine();
                    HORIZ = 1;
                    VERT++;


                }
            }
        }
    }
}
