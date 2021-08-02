using System;
using System.Collections.Generic;

namespace Cs2_Day_05_2
{
    class Cs2_Day_05_Saraksti
    {
        static void Main(string[] args)
        {
            List<string> Vardi = new List<string>();
            string darbiba;

            do
            {
                Console.WriteLine("Kādu darbību Tu vēlies veikt ar List? " +
                     "- 1 - pievienot elementu - 2 - izvadīt List - 3 - iziet?");

                darbiba = Console.ReadLine();

                if (darbiba == "1")
                {
                    Console.Write("Uzraksti, ko pievienot List -     ");
                    AddElements(Console.ReadLine(), Vardi);
                }
                else if (darbiba == "2")
                {
                    if (Vardi.Count == 0)
                    {
                        Console.WriteLine("List ir tukšs!");
                    }
                    else
                    {
                        PrintList(Vardi);
                    }

                }
                else if (darbiba != "1" && darbiba != "2" && darbiba != "3")
                {
                    Console.WriteLine("Šādas darbības nav!");
                }

            } while (!darbiba.Equals("3"));
        }

        public static void AddElements(string vards, List<string> Vardi)
        {
            Vardi.Add(vards);
        }

        public static void PrintList(List<string> Vardi)
        {
            foreach (string item in Vardi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
