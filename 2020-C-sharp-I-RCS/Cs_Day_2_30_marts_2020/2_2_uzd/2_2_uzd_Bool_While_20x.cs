using System;

namespace _2_2_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BOOL atkartojums 20 reizes!");

            bool a = true;
            int i = 0;

            while (a)
            {
                Console.WriteLine(i);
                i++;

                if (i == 20)
                {
                    a = false;
                }

            }

        }
    }
}
