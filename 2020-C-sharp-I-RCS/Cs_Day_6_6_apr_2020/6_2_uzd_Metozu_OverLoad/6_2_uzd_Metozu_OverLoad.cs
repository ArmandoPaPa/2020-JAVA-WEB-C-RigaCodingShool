using System;

namespace _6_2_uzd_Metozu_OverLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi savu vardu - ");
            string Name = Console.ReadLine();

            Console.Write("Ievadi savu uzvardu - ");
            string Surname = Console.ReadLine();

            Console.Write("Ievadi savu vecumu - ");
            string Age = Console.ReadLine();
            int Age_number;
            bool Parbaude = int.TryParse(Age, out Age_number);

            if (string.IsNullOrEmpty(Age) || !Parbaude)
            {
                PrintNameAge(Name);
            }
            else
            {
                PrintNameAge(Name, Age_number);
            }

            PrintNameSurname(Name);
            PrintNameSurname(Name, Surname);


        }

        static void PrintNameSurname(string Name)
        {
            Console.WriteLine($"Tavs vards ir {Name}");
        }

        static void PrintNameSurname(string Name, string Surname)
        {
            Console.WriteLine($"Tavs vards ir {Name}, uzvards {Surname}");
        }

        static void PrintNameAge(string Name, int Age = 99)
        {
            Console.WriteLine($"Labdien, {Name}, tev ir {Age} gadi!");
        }

    }
}
