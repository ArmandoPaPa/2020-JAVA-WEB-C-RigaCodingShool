using System;

namespace Cs2_Day_02
{
    class Cs2_Day_02
    {
        static void Main(string[] args)
        {
            //Day2_Task01();

            //Day2_Task01_Extra();

            //Day2_Task02();

            Day2_Task03();

        }

        public static void DarbsKlase() //Loops & Arrays
        {
            Random rand = new Random();
            int a = rand.Next(60);

            int[] masivs = new int[5];
            masivs[0] = 4;
            //...
            masivs[4] = 3;

            for (int i = 0; i < masivs.Length; i++)
            {
                masivs[i] = 69;
            }

        }

        public static void Day2_Task01()
        {
            //1) Ģenerēt 10 random skaitļus ar for ciklu(0 - 59)
            //2) Izvadīt lielāko.
            //(realizēt neizmantojot masīvus vai sarakstus)

            int skaitlis = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int temp = rnd.Next(60);
                if (skaitlis < temp)
                {
                    skaitlis = temp;
                }
            }
            Console.WriteLine(skaitlis);
        }

        public static void Day2_Task01_Extra()
        {
            //1) Cilvēks ievada 10 jebkādus skaitļus;
            //2) Izvadīt lielāko.
            //(realizēt neizmantojot masīvus vai sarakstus)

            int skaitlis = int.MinValue;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ievadi skaitli nr. " + i + "     ");
                int temp = int.Parse(Console.ReadLine());
                if (skaitlis < temp)
                {
                    skaitlis = temp;
                }
            }
            Console.WriteLine("Tevis ievadītais lielākais skaitlis ir     " + skaitlis);
        }

        public static void Day2_Task02()
        {
            /*
                *
                **
                ***
                ****

                extra
                ****
                ***
                **
                * 
            */
            string zvaigznes = "";

            for (int i = 0; i < 4; i++)
            {
                zvaigznes += "*";
                Console.WriteLine(zvaigznes);
            }

            for (int i = 0; i < zvaigznes.Length; i++)
            {
                Console.WriteLine(zvaigznes.Substring(i));
            }

            for (int i = 0; i < 4; i++) // alternatīvs risinājums iepriekšējam risinājumam ar Substring
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Day2_Task03()
        {
            /*
                1) Lietotājs ievada masīva elementus, masīva garums ir 5.
                2) Izvadīt parastā secībā.
                3) Izvadīt apgrieztā secībā.

                #extra
                Lietotājs ievada 6.vērtību, izdomāt kā pievienot šo vērtību masīvam. 
            */

            string[] masivs = new string[5];

            Console.WriteLine("Tev tagad vajadzēs aizpildīt masīvu ar vērtībām!");

            for (int i = 0; i < masivs.Length; i++)
            {
                Console.Write("Aizpildi masīva " + i + " .vērtību!     ");
                masivs[i] = Console.ReadLine();
            }

            Console.Write("[");
            for (int i = 0; i < masivs.Length - 1; i++)
            {
                Console.Write(" " + masivs[i] + ",");
            }
            Console.Write(" " + masivs[masivs.Length - 1] + " ]");

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("[");
            for (int i = 1; i < masivs.Length; i++)
            {
                Console.Write(" " + masivs[masivs.Length - i] + ",");
            }
            Console.Write(" " + masivs[0] + " ]");

            Console.WriteLine();
            Console.WriteLine();

            string[] masivs2 = new string[6];
            Array.Copy(masivs, 0, masivs2, 0, masivs.Length);
            Console.Write("Ievadi masīva 6.elementu!     ");
            masivs2[masivs2.Length - 1] = Console.ReadLine();

            Console.Write("[");
            for (int i = 0; i < masivs2.Length - 1; i++)
            {
                Console.Write(" " + masivs2[i] + ",");
            }
            Console.Write(" " + masivs2[masivs2.Length - 1] + " ]");

        }

    }
}
