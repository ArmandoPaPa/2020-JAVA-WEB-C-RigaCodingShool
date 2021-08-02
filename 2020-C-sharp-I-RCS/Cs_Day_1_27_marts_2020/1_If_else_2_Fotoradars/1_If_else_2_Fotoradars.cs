using System;

namespace _1_If_else_2_Fotoradars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi, par cik km/h Tu parsniedzi brauksanas atrumu!");

            string atrums = Console.ReadLine();

            double x = double.Parse(atrums);

            if (x<10)
            {
                Console.WriteLine("Tu neparsniedzi atrumu vai Tavs parsniegtais atrums ir nebutisks!");
            }
            else if (x>=10 && x<20)
            {
                Console.WriteLine("Tu parsniedzi atrumu - SODS - 15 EUR");
            }
            else if (x>=20 && x<30)
            {
                Console.WriteLine("Tu parsniedzi atrumu - SODS - 30 EUR");
            }
            else if (x>=30)
            {
                Console.WriteLine("Tu stipri parsniedzi atrumu - SODS - TIESIBAS NOST!");
            }

        }
    }
}
