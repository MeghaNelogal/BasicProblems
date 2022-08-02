using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public static class SwapNumbers
    {
        public static void Swapping()
        {
            Console.WriteLine("Enter number num1 and num2: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping two numbers");
            Console.WriteLine("value of num1 -> " + num1);
            Console.WriteLine("value of num2 -> " + num2);

            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;

            Console.WriteLine("After Swapping two number: ");
            Console.WriteLine("value of num1 -> " + num1);
            Console.WriteLine("value of num2 -> " + num2);
        }
    }
}

