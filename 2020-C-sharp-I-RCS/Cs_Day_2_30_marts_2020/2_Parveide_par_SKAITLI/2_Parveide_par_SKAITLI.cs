using System;

namespace _2_Parveide_par_SKAITLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi jebko, mes izdrukasim Tevis ievaditos skaitlus!");

            Console.Write("Ievadi pirmo vertibu!   ");
            string a = Console.ReadLine();

            Console.Write("Ievadi otro vertibu!   ");
            string b = Console.ReadLine();

            Console.Write("Ievadi treso vertibu!   ");
            string c = Console.ReadLine();

            Console.Write("Ievadi ceturto vertibu!   ");
            string d = Console.ReadLine();

            Console.Write("Ievadi piekto vertibu!   ");
            string e = Console.ReadLine();

            int a_sk;
            bool a_a = int.TryParse(a, out a_sk);

            int b_sk;
            bool b_b = int.TryParse(b, out b_sk);

            int c_sk;
            bool c_c = int.TryParse(c, out c_sk);

            int d_sk;
            bool d_d = int.TryParse(d, out d_sk);

            int e_sk;
            bool e_e = int.TryParse(e, out e_sk);

            if (a_a && b_b && c_c && d_d && e_e)
            {
                Console.WriteLine("Visu Tevis ievadito var parveidot par skaitliem!");
            }
            else
            {
                Console.WriteLine("No Tevis ievadita, par skaitliem nevar parveidot sekojoso:");
                if (!a_a)
                {
                    Console.WriteLine(a);
                }
                if (!b_b)
                {
                    Console.WriteLine(b);
                }
                if (!c_c)
                {
                    Console.WriteLine(c);
                }
                if (!d_d)
                {
                    Console.WriteLine(d);
                }
                if (!e_e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
