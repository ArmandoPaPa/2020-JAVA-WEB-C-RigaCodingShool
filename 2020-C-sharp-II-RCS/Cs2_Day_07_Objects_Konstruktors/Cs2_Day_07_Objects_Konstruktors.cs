using System;

namespace Cs2_Day_07_Objects_Konstruktors
{
    class Cs2_Day_07_Objects_Konstruktors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("studentOne ievade!");
            Students studentOne = new Students(vardaIevade(), uzvardaIevade(), kursaIevade ());

            Console.WriteLine();

            Console.WriteLine("studentTwo ievade!");
            Students studentTwo = new Students(vardaIevade(), uzvardaIevade(), kursaIevade());

            Console.WriteLine();

            studentOne.PrintInfo();
            
            Console.WriteLine();
            
            studentTwo.PrintInfo();
        }

        public static string vardaIevade()
        {
            Console.Write("Ievadi savu vārdu!   ");
            String vards = Console.ReadLine();
            return vards;
        }

        public static string uzvardaIevade()
        {
            Console.Write("Ievadi savu uzvārdu!   ");
            String uzvards = Console.ReadLine();
            return uzvards;
        }

        public static int kursaIevade()
        {
            int kurss;
            do
            {
                Console.WriteLine("Ievadi kursu - 1, 2 vai 3!");
                try
                {
                    kurss = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    kurss = kursaIevade();
                }
            } while (kurss != 1 && kurss != 2 && kurss != 3);

            return kurss;
        }

    }
}
