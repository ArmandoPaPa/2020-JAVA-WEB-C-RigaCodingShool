using System;
using System.Collections.Generic;
using System.Text;

namespace Cs2_Day_04
{
    class Class1
    {
        // private un public

        public static void TestPrint()
        {
            Console.WriteLine("Hello World!");
            PrivPrint();
        }

        private static void PrivPrint()
        {
            Console.WriteLine("Šo mainā neredz!");
        }
    }
}
