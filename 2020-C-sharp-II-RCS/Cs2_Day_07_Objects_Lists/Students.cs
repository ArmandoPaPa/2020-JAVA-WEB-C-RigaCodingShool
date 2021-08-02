using System;
using System.Collections.Generic;
using System.Text;

namespace Cs2_Day_07_Objects_Lists
{
    class Students
    {
        public string studentaVards { get; set; }
        public string studentaUzvards { get; set; }
        public int studentaKurss { get; set; }

        public Students (String studentaVards, String studentaUzvards, int studentaKurss)
        {
            this.studentaVards = studentaVards;
            this.studentaUzvards = studentaUzvards;
            this.studentaKurss = studentaKurss;

        }

        public void PrintInfo()
        {
            Console.WriteLine(studentaVards + " " + studentaUzvards + ", " + studentaKurss + ". kurss");
        }
    }
}
