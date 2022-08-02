using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public static class PowerOfTwo
    {
        public static void CheckPower()
        {
            Console.WriteLine("Enter the number-> ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2 to the power of {0} is -> " + Math.Pow(2, i), i);
            }
        }
    }
}
