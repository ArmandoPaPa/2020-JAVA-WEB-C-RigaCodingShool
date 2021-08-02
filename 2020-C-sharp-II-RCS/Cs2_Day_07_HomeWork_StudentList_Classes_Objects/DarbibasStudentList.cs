using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;

namespace Cs2_Day_07_HomeWork_StudentList_Classes_Objects
{
    class DarbibasStudentList
    {

        private static List<Students> ListOfStudents = new List<Students>();

        public static void Darbibas()
        {
            string Izvele;
            do
            {
                Console.WriteLine("Izvēlies kādu darbību Tu vēlies veikt?");
                Console.WriteLine("Ievadi - 1 - Pievienot studentu sarakstam - 2 - Izdzēst studentu no saraksta" +
                    " - 3 - Izprintēt sarakstu - 4 - exit");
                Izvele = Console.ReadLine();
            } while (!Izvele.Equals("1") && !Izvele.Equals("2") && !Izvele.Equals("3") && !Izvele.Equals("4")
                        && !Izvele.Equals("exit"));

            Console.WriteLine();

            DarbibasArList(Izvele);
        }

        private static void DarbibasArList(String Darbiba)
        {
            switch (Darbiba)
            {
                case "1":
                    ListOfStudents.Add(new Students(vardaIevade(), uzvardaIevade(), kursaIevade()));
                    Console.WriteLine("Students pievienots!");
                    Console.WriteLine();
                    Darbibas();
                    break;

                case "2":

                    if (ListOfStudents.Count < 1)
                    {
                        Console.WriteLine("Studentu saraksts ir tukšs! Izvēlies citu darbību!");
                        Console.WriteLine();
                        Darbibas();
                    }

                    else
                    {
                        Console.WriteLine("Esošais studentu saraksts ir sekojošs:");
                        for (int i = 0; i < ListOfStudents.Count; i++)
                        {
                            Console.Write(i + "   ");
                            ListOfStudents[i].PrintInfo();
                        }
                        Console.WriteLine();
                        ListOfStudents.RemoveAt(studentaDzesana(ListOfStudents));
                        Console.WriteLine("Students izdzēsts!");
                        Console.WriteLine();
                        Darbibas();
                    }
                    break;

                case "3":
                    if (ListOfStudents.Count < 1)
                    {
                        Console.WriteLine("Studentu saraksts ir tukšs! Izvēlies citu darbību!");
                        Console.WriteLine();
                        Darbibas();
                    }
                    else
                    {
                        PrintList(ListOfStudents);
                        Console.WriteLine();
                        Darbibas();
                    }
                    break;

                case "4":
                    Console.WriteLine("Paldies! Darbs ar List beidzies!");
                    break;

                default:
                    Console.WriteLine("Paldies! Darbs ar List beidzies!");
                    break;
            }
        }

        // Students studentOne = new Students(vardaIevade(), uzvardaIevade(), kursaIevade ());

        // listOfStudents.Add(new Students(vardaIevade(), uzvardaIevade(), kursaIevade()));

        private static string vardaIevade()
        {
            Console.Write("Ievadi savu vārdu!   ");
            String vards = Console.ReadLine();
            return vards;
        }

        private static string uzvardaIevade()
        {
            Console.Write("Ievadi savu uzvārdu!   ");
            String uzvards = Console.ReadLine();
            return uzvards;
        }

        private static int kursaIevade()
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

        private static int studentaDzesana(List<Students> ListOfStudents)
        {
            int studentaIndex;
            do
            {
                Console.Write("Ievadi studenta Nr., kuru dzēst!     ");
                try
                {
                    studentaIndex = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    studentaIndex = studentaDzesana(ListOfStudents);
                }
            } while (studentaIndex < 0 || studentaIndex >= ListOfStudents.Count);

            return studentaIndex;
        }

        private static void PrintList(List<Students> ListOfStudents)
        {
            Console.WriteLine("Esošais studentu saraksts ir sekojošs:");
            for (int i = 0; i < ListOfStudents.Count; i++)
            {
                Console.Write(i + "   ");
                ListOfStudents[i].PrintInfo();
            }
            Console.WriteLine();
            // Darbibas(); - mājās paskatīties par static visur un šo!
        }
    }
}
