using System;

namespace _3_2_uzd_String_Masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vardi = new string[] { "Janis", "Peteris", "Andris" };

            Console.WriteLine(vardi[1]);

            vardi[2] = "Jekabs";

            Console.WriteLine(vardi[vardi.Length - 1]);

        }
    }
}
