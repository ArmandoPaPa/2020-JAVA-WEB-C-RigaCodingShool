using System;
using System.Collections.Generic;

namespace Cs2_Day_06_List_Remove_TryCatch
{
    class Cs2_Day_06_List_Remove_TryCatch
    {
        static void Main(string[] args)
        {
            List<string> Vardi = new List<string>();
            string darbiba;

            do
            {
                Console.WriteLine("Kādu darbību Tu vēlies veikt ar List? " +
                     "- 1 - pievienot elementu - 2 - izvadīt List - 3 - iziet - 4 - dzēst elementu ?");

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

                else if (darbiba == "4")
                {
                    int elm = Parbaude();

                    if (elm >=0 && elm < Vardi.Count)
                    {
                        RemoveElements(elm, Vardi);
                    }
                    else
                    {
                        Console.WriteLine("Šāda elementa nav sarakstā!");
                    }

                }

                else if (darbiba != "1" && darbiba != "2" && darbiba != "3" && darbiba != "4")
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

        public static void RemoveElements(int elm, List<string> Vardi)
        {
            Vardi.RemoveAt(elm);
        }

        public static int Parbaude()
        {
            int elemnumber = 0;
            try
            {
                Console.Write("Ievadu, kuru saraksta elementu Tu vēlies dzēst!     ");
                elemnumber = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ievadi saraksta elementu skaitļiem!   ");
                elemnumber = Parbaude();
            }

            return elemnumber;
        }

    }
}
