using System;

namespace _1_4_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            string vards = "Armands";

            string uzvards = "Blumbergs";

            string pilseta = "Riga";

            string rajons = "Vecmilgravis";

            Console.WriteLine(vards + " " + uzvards + " dzivo " + pilseta + ", " + rajons + ".");

            Console.WriteLine($"{vards} {uzvards} dzivo {pilseta}, {rajons}.");

            string x = string.Format("{0} {1} dzivo {2}, {3}.", vards, uzvards, pilseta, rajons);

            Console.WriteLine(x);

            Console.WriteLine(string.Format("{0} {1} dzivo {2}, {3}.", vards, uzvards, pilseta, rajons));

        }
    }
}
