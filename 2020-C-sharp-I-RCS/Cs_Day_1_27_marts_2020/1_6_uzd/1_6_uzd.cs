using System;

namespace _1_6_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi kadu majas prieksmeta nosaukumu, mes to kaut kur maja!");
            string prieksmets = Console.ReadLine();

            prieksmets = prieksmets.ToLower();

            string sakuma_burts = prieksmets.Substring(0, 1);

            if (sakuma_burts == "a" || sakuma_burts == "b" || sakuma_burts == "c" || sakuma_burts == "d")
            {
                Console.WriteLine($"{prieksmets} tiks novietots majas 1.stava!");
            }

            else if (sakuma_burts == "e" || sakuma_burts == "f" || sakuma_burts == "g" || sakuma_burts == "h")
            {
                Console.WriteLine($"{prieksmets} tiks novietots majas 2.stava!");
            }

            else if (sakuma_burts == "i" || sakuma_burts == "j" || sakuma_burts == "k" || sakuma_burts == "l")
            {
                Console.WriteLine($"{prieksmets} tiks novietots majas 3.stava!");
            }

            else if (sakuma_burts == "m" || sakuma_burts == "n" || sakuma_burts == "o" || sakuma_burts == "p")
            {
                Console.WriteLine($"{prieksmets} tiks novietots majas 4.stava!");
            }

            else if (sakuma_burts == "r" || sakuma_burts == "s" || sakuma_burts == "t" || sakuma_burts == "u")
            {
                Console.WriteLine($"{prieksmets} tiks novietots majas 5.stava!");
            }

            else
            {
                Console.WriteLine($"{prieksmets} tiks novietots majas pagraba!");
            }

        }
    }
}
