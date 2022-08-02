using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public static class HarmonicNumber
    {
        public static void CheckHarmonicNum()
        {
            double Num, harmonic = 0;
            Console.Write("Enter Number For Harmonic sereis no : ");
            Num = Convert.ToInt32(Console.ReadLine());

            for (double n = 1; n <= Num; n++)
            {
                harmonic = harmonic + (1 / n);
                Console.WriteLine("1" + "/" + n);
            }

            Console.WriteLine("Harmonic Number of Number {0} is : {1}", Num, harmonic);
        }
    }
}
