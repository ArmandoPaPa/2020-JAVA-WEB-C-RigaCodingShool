using System;

namespace _1_5_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi skaitli!");
            string x = Console.ReadLine();

            Console.WriteLine("Ievadi otru skaitli!");
            string y = Console.ReadLine();

            int x_skaitlis = int.Parse(x);
            int y_skaitlis = int.Parse(y);

            if (x_skaitlis >= 0 && x_skaitlis<=20 && y_skaitlis>=30 && y_skaitlis<=50)
            {
                Console.WriteLine("Tevis ievadito skaitlu summa ir " + (x_skaitlis + y_skaitlis));
            }
            else
            {
                Console.WriteLine("KLUDA! Tavs pirmais ievaditais skaitlis nav robezas 0-20 " +
                    "VAI otrais ievaditais skaitlis nav robezas 30-50 " +
                    "VAI ABI nav attiecigajas robezas!");
            }

        }
    }
}
