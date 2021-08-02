using System;

namespace _6_4_uzd_PersonasKODS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi savu personas kodu formata xxxxxx-xxxxx   ");
            string PersonasKods = Console.ReadLine();

            ValidatePersonId(PersonasKods);
        }

        static void ValidatePersonId(string PersonasKods)
        {
            if (PersonasKods.Length != 12 || PersonasKods.Substring(6, 1) != "-"
                || int.Parse(PersonasKods.Substring(0, 2)) > 31
                || int.Parse(PersonasKods.Substring(0, 2)) < 1)
            {
                Console.WriteLine("Tu ievadiji personas kodu nepareizi! Ievadei jabut xxxxxx-xxxxx" +
                    " vai datums ir ievadīts nepareizs!");
            }

            else
            {
                PrintBirthday(PersonasKods);
            }
        }

        static void PrintBirthday(string PersonasKods)
        {
            if (int.Parse(PersonasKods.Substring(4, 2)) > 19)
            {
                switch (int.Parse(PersonasKods.Substring(2, 2)))
                {
                    case 01:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.janvāris, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 02:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.februāris, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 03:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.marts, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 04:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.aprīlis, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 05:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.maijs, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 06:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.jūnijs, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 07:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.jūlijs, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 08:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.augusts, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 09:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.septembris, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 10:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.oktobris, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 11:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.novembris, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 12:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.decembris, " +
                            $"19{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    default:
                        Console.WriteLine("Tu ievadiji nepareizu personas kodu!");
                        break;
                }
            }

            if (int.Parse(PersonasKods.Substring(4, 2)) < 20)
            {
                switch (int.Parse(PersonasKods.Substring(2, 2)))
                {
                    case 01:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.janvāris, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 02:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.februāris, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 03:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.marts, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 04:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.aprīlis, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 05:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.maijs, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 06:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.jūnijs, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 07:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.jūlijs, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 08:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.augusts, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 09:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.septembris, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 10:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.oktobris, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 11:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.novembris, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    case 12:
                        Console.WriteLine($"{PersonasKods.Substring(0, 2)}.decembris, " +
                            $"20{PersonasKods.Substring(4, 2)}.gads.");
                        break;
                    default:
                        Console.WriteLine("Tu ievadiji nepareizu personas kodu!");
                        break;
                }
            }
        }

    }
}
