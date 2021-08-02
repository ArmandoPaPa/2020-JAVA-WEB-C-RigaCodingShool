using System;
using System.Collections.Generic;
using System.Text;

namespace Cs2_Day_08_Taisnsturis
{
    class DarbibasArTaisnsturiem
    {  
            /*
            1) Uztaisīt klasi "Taisnstūris". Vajag, garumu, augstumu, un aprēķināt laukumu.
               (mala1* mala2)
            2) Uztaisīt tā, lai lietotājs ievada visas vajadzīgās vērtības 10 Taisnstūriem.
            3) Ja lietotājs ievada nepareizas vērtības(Stringus, -1, -22, utt)
               Neko nepievienot sarakstam, bet izvadīt kļūdas paziņijumu.
            4) Beigās izvadīt figūru skaitu un laukumus.

            */
        
        
        private static List<Taisnsturis> Tsaraksts = new List<Taisnsturis>();
        
        public static void Ievade()
        {
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Ievadi " + (i+1) + ". taisnstūra garumu, platumu!");
                Console.WriteLine();
                Console.Write("Ievadi taisnstūra garumu!     ");
                double garums = TryCatch();
                Console.Write("Ievadi taisnstūra platumu!     ");
                double platums = TryCatch();

                if (garums > 0 && platums > 0)
                {
                    Tsaraksts.Add(new Taisnsturis(garums, platums));
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lietotājs ir ievadījis " + (Tsaraksts.Count)
                + " derīgu taisnstūru parametrus");

            Console.WriteLine("Taisnstūru saraksta - laukumi!");

            for (int i = 0; i<Tsaraksts.Count; i++)
            {
                Console.Write(i + "   ");
                Tsaraksts[i].PrintInfo();
            }

        }

        private static double TryCatch()
        {
            double x;
            try
            {
                x = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                x = 0;
            }
            return x;
        }
    }
}
