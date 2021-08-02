using System;

namespace Cs2_Day_03
{
    class Cs2_Day_03
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi masiva garumu!     ");
            int masivaGarums = int.Parse(Console.ReadLine());

            int[] randomMasivs = Task01(masivaGarums);

            arrPrint(randomMasivs);

            Console.WriteLine();
            Console.WriteLine();

            Task01_Clear(randomMasivs);

            arrPrint(randomMasivs);

            Console.WriteLine();
            Console.WriteLine();

            // 2.uzdevums

            string[] masivs = { "aaa", "bbb", "ccc", "ddd", "eee" };

            Console.WriteLine("String masīva visu elementu garums ir  " + Task02(masivs) + "  zīmes!");


            Console.WriteLine();
            Console.WriteLine();

            // 2.uzd. EXTRA

            arrPrint(Task02_extra(Task01(masivaGarums)));


        }

        public static void Day_03_DarbsKlase()
        {

        }

        public static void arrPrint(int[] randomMasivs)
        {
            for (int i = 0; i < randomMasivs.Length; i++)
            {
                Console.Write(randomMasivs[i] + "   ");
            }
        }

        public static int[] Task01(int masivaGarums)
        {
            /*
                1) Uztaisīt metodi, kurai kā parametrs ir viens int tipa skaitlis- masīva garums.
                2) Metodei ir jāatgriež attiecīgā garuma int tipa masīvs, 
                   kurš ir aizpildīts ar Random skaitļiem no 0 - 100
                3) Uztaisīt metodi, kas kā parametru paņem masīvu (int tipa) 
                   un nonullē (piešķir 0 ) visus elementus, kuriem vērtība ir lielāka par 50.
                4) Izvadīt.
            */

            int[] randomMasivs = new int[masivaGarums];

            Random rnd = new Random();

            for (int i = 0; i < randomMasivs.Length; i++)
            {
                randomMasivs[i] = rnd.Next(101);
            }

            return randomMasivs;

        }

        public static void Task01_Clear(int[] randomMasivs)
        {
            for (int i = 0; i < randomMasivs.Length; i++)
            {
                if (randomMasivs[i] > 50)
                {
                    randomMasivs[i] = 0;
                }
            }
        }

        public static int Task02(string[] masivs)
        {
            /*
                1) Uztaisīt metodi, kas kā parametru ņem String tipa masīvu.
                2) Atgriezt visu String elementu garuma summu. 
            */

            int elemGarums = 0;

            for (int i = 0; i < masivs.Length; i++)
            {
                elemGarums += masivs[i].Length;
            }
            return elemGarums;

        }

        public static int[] Task02_extra(int[] arr)
        {
            /* 
                1) Uztaisīt metodi, kas kā parametru ņem int tipa masīvu.
                2) Sakārtot un izvadīt visus masīva elementus augošā secībā.
                    *cikls ciklā
                    *salīdzina't katru elementu ar katru elementu. 
                    * 3 glāžu principu.
             */

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;

        }
    }
}
