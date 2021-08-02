using System;
using System.Collections.Generic;

namespace Cs2_Day_10_1
{
    class Cs2_Day_10_1
    {
        /*
            1) Balstoties uz 9 dienas mājasdarbu-
            Uztaisīt tā, lai no faila tiek nolasīti skaitļi un saglabāti integer tipa listā.

            2) Menu
                Pievienot sarakstam,
                Dzest,
                Saskaitit visus skaitļus,
                Izrēķināt vidējo aritmētisko

            3) Pievienot sarakstam tikai skaitļus, 
                ja nav skaitlis, tad izvadīt kļūdas paziņojumu 
                (Var vienu paziņojumu visām nepareizajām vērtībām, vai arī atsevišķi katrai rindai)

            4) Ja atrodas kļudaina vērtība- dzēst to no faila. 
        */

        static void Main(string[] args)
        {
            FileOperations.ReadFile();
            DarbibasArIntList.DarbibasIzvele();
        }
    }
}

