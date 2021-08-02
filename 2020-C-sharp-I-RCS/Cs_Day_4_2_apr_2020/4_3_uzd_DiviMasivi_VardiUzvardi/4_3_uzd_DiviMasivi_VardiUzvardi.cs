using System;

namespace _4_3_uzd_DiviMasivi_VardiUzvardi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dargais draugs, tagad Tev vajadzes ievadit 10 vardus " +
                "un pec so cilveku uzvardus! Mes pec tam izvadisim Vards, Uzvards!");

            string[] vardi = new string[10];

            string[] uzvardi = new string[10];

            for (int i = 0; i < vardi.Length; i++)
            {
                Console.Write($"Ievadi {i + 1}. vardu - ");
                vardi[i] = Console.ReadLine();
            }

            Console.WriteLine("Tagad ievadisim uzvardus!");
            for (int i = 0; i < uzvardi.Length; i++)
            {
                Console.Write($"Ievadi {vardi[i]} uzvardu -");
                uzvardi[i] = Console.ReadLine();
            }

            string[] VU = new string[10];
            for (int i = 0; i < VU.Length; i++)
            {
                VU[i] = vardi[i] + " " + uzvardi[i];
            }

            Console.WriteLine("Tu ievadiji sekojosus vardus un uzvardus!");
            for (int i = 0; i < VU.Length; i++)
            {
                Console.WriteLine(VU[i]);
            }

        }
    }
}
