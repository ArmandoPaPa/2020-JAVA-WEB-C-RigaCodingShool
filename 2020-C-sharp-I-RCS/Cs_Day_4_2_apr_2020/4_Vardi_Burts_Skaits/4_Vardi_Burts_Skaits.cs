using System;

namespace _4_Vardi_Burts_Skaits
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vardi = new string[6] { "aaa", "bbb", "ccc", "aaa", "bbb", "ccc" };

            String[] pirmie_burti = new string[vardi.Length];

            int skaititajs = 0;

            for (int i = 0; i < pirmie_burti.Length; i++)
            {
                string PirmaisBurts = vardi[i].Substring(0, 1);
                bool Eksistesana = false;

                for (int j = 0; j < pirmie_burti.Length; j++)
                {
                    if (pirmie_burti[j] == PirmaisBurts)
                    {
                        Eksistesana = true;
                        break;
                    }
                }

                if (!Eksistesana)
                {
                    pirmie_burti[i] = PirmaisBurts;
                    skaititajs++;
                }
            }

            int[] burtu_skaits = new int[skaititajs];

            for (int i = 0; i < burtu_skaits.Length; i++)

            {
                for (int j = 0; j < vardi.Length; j++)
                {
                    if (pirmie_burti[i] == vardi[j].Substring(0, 1))
                    {
                        burtu_skaits[i]++;
                    }
                }

                Console.WriteLine($"Burts {pirmie_burti[i]} ir sastopams ka pirmais " +
                    $"burts {burtu_skaits[i]} vardos");
            }
        }
    }
}
