using System;

namespace _3_Masivi_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nulleViens = new int[] { 1, 1, 1, 0, 1, 1, 1, 1 };

            for (int i = 0; i < nulleViens.Length; i++)
            {
                if (nulleViens[i] == 0)
                {
                    break;
                }
            }
        }

    }
}
