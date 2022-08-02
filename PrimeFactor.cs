using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public static  class PrimeFactor
    {
         public static void FindFactor()
        {
             int a, b;
             Console.WriteLine("Enter a positive integer: ");
             a = int.Parse(Console.ReadLine());
             for (b = 1; b <= a; b++)
             {
                if (a % b == 0)
                {
                    Console.Write(b + "  ");
                }
             }
             Console.Write("are the factors of " + a + "\n");
         }
    }
}
