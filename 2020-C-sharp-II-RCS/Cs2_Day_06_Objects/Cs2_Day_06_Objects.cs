using System;

namespace Cs2_Day_06_Objects
{
    class Cs2_Day_06_Objects
    {
        static void Main(string[] args)
        {
            /*
                1) Uztaisīt studentu klasi.
                Klasē jābūt- vārds, uzvārds, kurss.
                Kursam ir jāpārbauda vai vērtība ir no 1 - 3 ieskaitot, 
                ja ir vairāk par 3, tad piešķiram 3, ja mazāk par 1, tad piešķiram 1. 

                2) Publisku metodi PrintInfo()

                3) Vērtības(vārdu, uzvārdu un kursu ievada lietotājs)
             
             */

            Student students1 = new Student();

            Console.WriteLine("Student 1!");
            Console.WriteLine();

            Console.Write("Ievadi savu vārdu!     ");
            students1.vards = Console.ReadLine();

            Console.Write("Ievadi savu uzvārdu!     ");
            students1.uzvards = Console.ReadLine();

            Console.Write("Ievadi savu kursu ar veseliem skaitļiem!     ");
            students1.kursaParbaude(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Student 2!");
            Console.WriteLine();

            Student students2 = new Student();

            Console.Write("Ievadi savu vārdu!     ");
            students2.vards = Console.ReadLine();

            Console.Write("Ievadi savu uzvārdu!     ");
            students2.uzvards = Console.ReadLine();

            Console.Write("Ievadi savu kursu ar veseliem skaitļiem!     ");
            students2.kursaParbaude(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Student 3!");
            Console.WriteLine();

            Student students3 = new Student();

            Console.Write("Ievadi savu vārdu!     ");
            students3.vards = Console.ReadLine();

            Console.Write("Ievadi savu uzvārdu!     ");
            students3.uzvards = Console.ReadLine();

            Console.Write("Ievadi savu kursu ar veseliem skaitļiem!     ");
            students3.kursaParbaude(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine();

            students1.PrintInfo();
            students2.PrintInfo();
            students3.PrintInfo();

        }
    }
}
