using System;
using System.Diagnostics.CodeAnalysis;

namespace Cs2_Day_01_IO
{
    class Cs2_Day_01_IO
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();

            Console.Write("Ievadi skaitli! Mēs noteiksim, vai tas ir pozitīvs vai negatīvs!   ");
            int skaitlis = int.Parse(Console.ReadLine());

            Task3_1(skaitlis);

            Console.WriteLine("Tavs ievadītais skaitlis ir 0 vai pozitīvs -   " + Task3_2(skaitlis));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ievadi, cik skaitļus tu vēlies ievadīt, mēs aprēķināsim to summu!");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Tevis ievadīto skaitļu summa ir    " + Task3_3(count));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Tev vajadzes ievadit skaitli un pakapi, kura to kapinat!");
            Console.Write("Ievadi veselu, pozitivu skaitli, ko kapinat!     ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Ievadi, kurā pakāpē Tu vēlies kāpināt savu skaitli!     ");
            int pakape = int.Parse(Console.ReadLine());

            Console.WriteLine("Tevis ievadītais skaitlis " + number + " kāpināts " + pakape +
                " pakāpē ir     " + Task3_4(number, pakape));
        }

        static void DarbsKlase01()
        {
            Console.WriteLine("Hello World!");

            String input = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(input);
                Console.WriteLine(number);
            }
            catch
            {
                Console.WriteLine("Nav OK");
            }

            for (int i = 0; i < 10; i++)
            {

            }
        }

        static void Task1()
        {
            //Lietotājs ievada skaitli, ja skaitlis ir lielāks par 5, izvadīt **, ja nē tad *

            Console.Write("Ievadi skaitli!  ");
            String skaitlis = Console.ReadLine();
            try
            {
                int number = Convert.ToInt32(skaitlis);
                if (number > 5)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("*");
                }

            }
            catch
            {
                Console.WriteLine("Tu neievadīji derīgu skaitli!");
            }
        }

        static void Task2()
        {
            // Uztaisīt tā, lai lietotājs ievada 10 skaitļus, izvadīt skaitļu summu.

            Console.WriteLine("Lūdzu, ievadi 10 skaitļus!   ");
            int summa = 0;
            for (int i = 0; i < 10; i++)
            {
                string skaitlis = Console.ReadLine();
                int x = Convert.ToInt32(skaitlis);
                summa += x;
            }
            Console.WriteLine("Tevis ievadīto 10 skaitļu summa ir " + summa);
        }

        public static void Task3_1(int skaitlis)
        {
            //Uztaisīt metodi, kas kā parametru paņem vienu int tipa skaitli 
            //un izvada vai skaitlis ir pozitīvs vai negatīvs.

            if (skaitlis > 0)
            {
                Console.WriteLine("Tavs ievadītais skaitlis ir POZITĪVS");
            }
            else if (skaitlis < 0)
            {
                Console.WriteLine("Tavs ievadītais skaitlis ir NEGATĪVS");
            }
            else
            {
                Console.WriteLine("Tavs ievadītais skaitlis ir 0");
            }
        }

        public static bool Task3_2(int skaitlis)
        {
            //Paņemt kodu no pirmā punkta un pārveidot, 
            //lai pozitīva skaitļa gadījumā atgriež true, negatīva- false.

            if (skaitlis >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static int Task3_3(int count)
        {
            int summa = 0;
            for (int i = 1; i <= count; i++)
            {
                Console.Write("Ievadi skaitli nr. " + i + "     ");
                int input = int.Parse(Console.ReadLine());
                summa += input;
            }

            return summa;
        }

        public static int Task3_4(int number, int pakape)
        {
            int rezultats = (int)Math.Pow(number, pakape);

            return rezultats;
        }


    }
}
