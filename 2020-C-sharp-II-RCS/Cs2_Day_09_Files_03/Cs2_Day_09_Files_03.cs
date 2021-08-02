using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cs2_Day_09_Files_03
{
    class Cs2_Day_09_Files_03
    {
        private const string Mape = @"C:\Users\Armando PaPa\Desktop\MaM plus\RigaCoding\C#\Cs_2nd_TIME\Cs2_Day_09_Files_03\";

        static void Main(string[] args)
        {

            WriteFile(ReadFile());
        
        }

        public static void WriteFile(List<string> sarakts)
        {
            try
            {
                StreamWriter SW = new StreamWriter(Mape + "newText.txt", false);
                for (int i = sarakts.Count -1; i >= 0; i--)
                {
                    SW.WriteLine(sarakts[i]);
                }
                SW.Close();
            }
            catch
            {
                Console.WriteLine("Pievienot neizdevās!");
            }
        }


        public static List<string> ReadFile()
        {
            List<string> Saraksts = new List<string>();
            try
            {
                StreamReader SR = new StreamReader(Mape + "Text.txt");
                string line = SR.ReadLine();

                while (line != null)
                {
                    Saraksts.Add(line);
                    line = SR.ReadLine();
                }
                SR.Close();
            }
            catch
            {
                Console.WriteLine("Nolasīt NEIZDEVAS!");
            }
            return Saraksts;
        }
    }
}
