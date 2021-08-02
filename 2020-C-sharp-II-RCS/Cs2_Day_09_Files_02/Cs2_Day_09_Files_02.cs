using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Cs2_Day_09_Files_02
{
    class Cs2_Day_09_Files_02
    {
        
        private const string Mape = @"C:\Users\Armando PaPa\Desktop\MaM plus\RigaCoding\C#\Cs_2nd_TIME\Cs2_Day_09_Files_02\";

        static void Main(string[] args)
        {
            List<string> Saraksts = new List<string> { "aaa", "bbb", "ccc", "ddd", "eee" };

            WriteFile(Saraksts);
        }

        public static void WriteFile (List<string> sarakts)
        {
            try
            {   
                StreamWriter SW = new StreamWriter(Mape + "Text.txt", false);
                for (int i = 0; i<sarakts.Count; i++)
                {
                    SW.WriteLine(sarakts.ElementAt (i));
                }
                SW.Close();
            }
            catch
            {
                Console.WriteLine("Pievienot neizdevās!");
            }
        }


        public static void ReadFile(string fails)
        {
            try
            {
                StreamReader SR = new StreamReader(Mape + fails + ".txt");
                string line = SR.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = SR.ReadLine();
                }

                SR.Close();
            }
            catch
            {
                Console.WriteLine("Nolasīt NEIZDEVAS!");
            }
        }
    }
}

