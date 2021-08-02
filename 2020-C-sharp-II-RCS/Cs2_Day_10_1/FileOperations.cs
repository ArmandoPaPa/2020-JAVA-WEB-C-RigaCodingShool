using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Cs2_Day_10_1
{
    class FileOperations
    {
        private const string Mape = @"C:\Users\Armando PaPa\Desktop\MaM plus\RigaCoding\C#\Cs_2nd_TIME\Cs2_Day_10_1\";
        public static void ReadFile() 
        {
            try
            {
                StreamReader SR = new StreamReader(Mape + "Text.txt");
                int readNumber;
                string line = SR.ReadLine();

                while (line != null)
                {
                    try
                    {
                        readNumber = Convert.ToInt32(line);
                        DarbibasArIntList.Skaitli.Add(readNumber);
                        line = SR.ReadLine();
                    }
                    catch
                    {
                        break;
                    }
                }
                SR.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevās nolasīt failu!!!");
            }

            WriteFile(DarbibasArIntList.Skaitli);

        }

        public static void WriteFile(List<int> Skaitli)
        {
            try
            {
                StreamWriter SW = new StreamWriter(Mape + "Text.txt", false);
                for (int i = 0; i < Skaitli.Count; i++)
                {
                    SW.WriteLine(Skaitli.ElementAt(i));
                }
                SW.Close();
            }
            catch
            {
                Console.WriteLine("Pievienot neizdevās!");
            }
        }

    }
}
