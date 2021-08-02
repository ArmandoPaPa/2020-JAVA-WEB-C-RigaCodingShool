using System;
using System.Collections.Generic;

namespace Cs2_Day_07_Objects_Lists
{
    class Cs2_Day_07_Objects_Lists
    {
        static void Main(string[] args)
        {

            List<Students> listOfStudents = new List<Students>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Studenta " + (i+1) + " datu ievade!");
                listOfStudents.Add(new Students(vardaIevade(), uzvardaIevade(), kursaIevade()));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < listOfStudents.Count; i++)
            {
                listOfStudents[i].PrintInfo();
            }

            /*
            
            Console.WriteLine("studentOne ievade!");
            Students studentOne = new Students(vardaIevade(), uzvardaIevade(), kursaIevade());

            Console.WriteLine();

            Console.WriteLine("studentTwo ievade!");
            Students studentTwo = new Students(vardaIevade(), uzvardaIevade(), kursaIevade());

            Console.WriteLine();

            studentOne.PrintInfo();

            Console.WriteLine();

            studentTwo.PrintInfo();
            
            }

            */

            static string vardaIevade()
            {
                Console.Write("Ievadi savu vārdu!   ");
                String vards = Console.ReadLine();
                return vards;
            }

            static string uzvardaIevade()
            {
                Console.Write("Ievadi savu uzvārdu!   ");
                String uzvards = Console.ReadLine();
                return uzvards;
            }

            static int kursaIevade()
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
}
