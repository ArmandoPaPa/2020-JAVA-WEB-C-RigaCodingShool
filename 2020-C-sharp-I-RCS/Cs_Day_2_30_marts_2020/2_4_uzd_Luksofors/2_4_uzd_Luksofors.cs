using System;

namespace _2_4_uzd_Luksofors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LUKSOFORS un 3 krustojumi!");

            Console.Write("Vai var izbraukt cauri 1.krustojumam. Ievadi TRUE, ja var, " +
                "un FALSE, ja nevar!   ");
            string one = Console.ReadLine();

            Console.Write("Vai var izbraukt cauri 2.krustojumam. Ievadi TRUE, ja var, " +
                "un FALSE, ja nevar!   ");
            string two = Console.ReadLine();

            Console.Write("Vai var izbraukt cauri 3.krustojumam. Ievadi TRUE, ja var, " +
                "un FALSE, ja nevar!   ");
            string three = Console.ReadLine();

            bool B_one = bool.Parse(one);
            bool B_two = bool.Parse(two);
            bool B_three = bool.Parse(three);

            if (B_one && B_two && B_three)
            {
                Console.WriteLine($"Luksofors 1 ir {B_one}, luksofors 2 ir {B_two}, " +
                    $"luksofors 3 ir {B_three}. Attiecigi visiem krustojumiem VAR IZBRAUKT CAURI!");
            }
            else
            {
                Console.WriteLine("Kads no luksoforiem nav izbraucams!");
            }

        }
    }
}
