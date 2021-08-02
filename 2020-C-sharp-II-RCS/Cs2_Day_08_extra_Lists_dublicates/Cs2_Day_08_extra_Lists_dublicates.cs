using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Cs2_Day_08_extra_Lists_dublicates
{
    class Cs2_Day_08_extra_Lists_dublicates
    {
        static void Main(string[] args)
        {
            /*
                1) Uztaisīt metodi, kas kā parametrus paņem divus int tipa listus.
                2) Metodei ir jāatgriež kopīgie elementi no abiem sarakstiem.

                Piemērs-
                1,2,3,4 un 99,1,7,3

                Jāatgriež 1 un 3
             */

            List<int> One = new List<int> { 1, 2, 3, 4 };
            List<int> Two = new List<int> { 99, 1, 7, 3 };

            foreach (int item in Dublicates(One, Two))
            {
                Console.Write(item + "   ");
            }
        }

        public static List<int> Dublicates(List<int> One, List<int> Two)
        {
            List<int> Dublicates = new List<int>();

            for (int i = 0; i < One.Count; i++)
            {
                for (int j = 0; j < Two.Count; j++)
                {
                    if (One.ElementAt(i) == Two.ElementAt(j))
                    {
                        Dublicates.Add(One.ElementAt(i));
                    }
                }
            }

            return Dublicates;
        }
    }
}
