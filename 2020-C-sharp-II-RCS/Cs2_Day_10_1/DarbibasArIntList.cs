using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;

namespace Cs2_Day_10_1
{
    class DarbibasArIntList
    {
        public static List<int> Skaitli = new List<int>();

        public static int DarbibasIzvele()
        {
            Console.WriteLine("Kādu darbību Tu vēlies veikt ar List? " +
                     "- 1 - pievienot elementu - 2 - dzēst elementu - 3 - izvadīt - " +
                     "4 - saskaitīt visus elementus - 5 - izrēķināt vidējo aritmētisko - 6 - iziet?");
            Console.WriteLine();

            int darbiba;
            do
            {
                try
                {
                    Console.Write("Ievadi darbību 1-6!     ");
                    darbiba = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Šādas darbības nav!");
                    darbiba = DarbibasIzvele();
                }
            }

            while (darbiba != 1 && darbiba != 2 && darbiba != 3 && darbiba != 4
                    && darbiba != 5 && darbiba != 6);

            Saraksts(Skaitli, darbiba);

            return darbiba;
        }

        public static List<int> Saraksts(List<int> Skaitli, int darbiba)
        {
            switch (darbiba)
            {
                case 1: // pievienot elementu
                    AddElements(Skaitli);
                    Console.WriteLine();
                    FileOperations.WriteFile(DarbibasArIntList.Skaitli);
                    DarbibasIzvele();

                    return Skaitli;

                case 2: // dzēst elementu
                    RemoveElements(Skaitli);
                    Console.WriteLine();
                    FileOperations.WriteFile(DarbibasArIntList.Skaitli);
                    DarbibasIzvele();
                    return Skaitli;

                case 3: // izvadīt (izprintēt) Listu
                    PrintList(Skaitli);
                    Console.WriteLine();

                    DarbibasIzvele();
                    return Skaitli;

                case 4: // saskaitīt visus elementus
                    Summa(Skaitli);
                    Console.WriteLine();

                    DarbibasIzvele();
                    return Skaitli;

                case 5: // izrēķināt vidējo aritmētisko
                    Average(Skaitli);
                    Console.WriteLine();

                    DarbibasIzvele();
                    return Skaitli;

                case 6: // iziet
                    Console.WriteLine();
                    Console.WriteLine("Paldies par darbu!");
                    FileOperations.WriteFile(DarbibasArIntList.Skaitli);
                    return Skaitli;

                default:
                    Console.WriteLine("Tu ievadīji kaut ko ne to :(   ");
                    Console.WriteLine();
                    FileOperations.WriteFile(DarbibasArIntList.Skaitli);
                    return Skaitli;
            }
        }

        public static int AddElements(List<int> Skaitli)
        {
            int number;
            try
            {
                Console.Write("Ievadi, kādu skaitli pievienot int Listam!     ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Tu ievadīji skaitli nepareizi! Ievadi veselu skaitli!");
                number = AddElements(Skaitli);
            }

            Skaitli.Add(number);
            return number;
        }

        public static int RemoveElements(List<int> Skaitli)
        {
            PrintList(Skaitli);

            int indexDelete;
            try
            {
                Console.Write("Ievadi indexu, kuru dzēst!     ");
                indexDelete = Convert.ToInt32(Console.ReadLine());
                if (indexDelete >= 0 && indexDelete < Skaitli.Count) // ???
                {
                    Skaitli.RemoveAt(indexDelete);
                    Console.WriteLine("Skaitlis dzēsts!");
                }
                else
                {
                    Console.WriteLine("Šāda skaitļa indeksa nav!");
                    indexDelete = RemoveElements(Skaitli);
                }
            }
            catch
            {
                Console.WriteLine("Tu ievadīji indeksu nepareizi! Ievadi veselu skaitli!");
                indexDelete = RemoveElements(Skaitli);
            }


            return indexDelete;
        }

        public static void PrintList(List<int> Skaitli)
        {
            if (Skaitli.Count < 1)
            {
                Console.WriteLine("Saraksts ir tukšs!");
            }
            else
            {
                for (int i = 0; i < Skaitli.Count; i++)
                {
                    Console.WriteLine(i + "   " + Skaitli[i]);
                }
            }
        }

        public static void Summa(List<int> Skaitli)
        {
            int sum = 0;
            if (Skaitli.Count < 1)
            {
                Console.WriteLine("Saraksts ir tukšs!");
            }
            else
            {
                for (int i = 0; i < Skaitli.Count; i++)
                {
                    sum += Skaitli[i];
                }
            }
            Console.WriteLine("Saraksta visu elementu summa ir " + sum);
        }

        public static void Average(List<int> Skaitli)
        {
            int sum = 0;
            if (Skaitli.Count < 1)
            {
                Console.WriteLine("Saraksts ir tukšs!");
            }
            else
            {
                for (int i = 0; i < Skaitli.Count; i++)
                {
                    sum += Skaitli[i];
                }
            }
            Console.WriteLine("Saraksta videjā vērtība ir " + (double)sum / Skaitli.Count);
        }

    }
}
