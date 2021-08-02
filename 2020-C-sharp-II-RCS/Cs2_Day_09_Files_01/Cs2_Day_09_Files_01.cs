using System;
using System.IO;

namespace Cs2_Day_09_Files_01
{
    class Cs2_Day_09_Files_01
    {
        private const string Mape = @"C:\Users\Armando PaPa\Desktop\MaM plus\RigaCoding\C#\Cs_2nd_TIME\Cs2_Day_09_Files_01\";
        
        static void Main(string[] args)
        {
            Console.WriteLine("IR pieejami sekojoši faili - Text");
            Console.Write("Kuru failu Tu vēlies lasīt?     ");
            string Fails = Console.ReadLine();

            ReadFile(Fails);
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
