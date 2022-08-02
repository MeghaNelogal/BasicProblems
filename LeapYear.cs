using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public static class LeapYear
    {
        public static void CheckLeapYear()
        {
            Console.WriteLine("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is leap year");
            }
            else
            {
                Console.WriteLine(year + " is not leap year");
            }
        }
    }
}
