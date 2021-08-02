using System;

namespace _2_1_uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EGLITES!");

            Console.Write("Kadu egliti Tu nopirki - sudrabegli VAI klasisko?   ");
            string egle = Console.ReadLine();

            Console.Write("Cik augsta ir tava egle - cm?   ");
            string augstums = Console.ReadLine();
            double x = double.Parse(augstums);

            Console.Write("Kads ir zaru diametrs - cm?   ");
            string zari = Console.ReadLine();
            double y = double.Parse(zari);

            if (egle == "sudrabegli")
            {
                Console.WriteLine($"Mes tavu {egle} novietosim KAMINZALE.");
            }

            else if (egle == "klasisko" && x >= 50 && x < 100 && y >= 100 && y < 150)
            {
                Console.WriteLine($"Mes tavu {egle} egli novietosim Viesistaba 1.");
            }

            else if (egle == "klasisko" && x >= 100 && x < 150 && y >= 150 && y < 200)
            {
                Console.WriteLine($"Mes tavu {egle} egli novietosim Viesistaba 2.");
            }

            else if (egle == "klasisko" && x >= 150 && x <= 300 && y >= 200 && y <= 300)
            {
                Console.WriteLine($"Mes tavu {egle} egli novietosim KAMINZALE.");
            }

            else
            {
                Console.WriteLine("Mes esam nezinam, kur novietot Tavu egli, bet mes padomasim!");
            }

        }
    }
}
