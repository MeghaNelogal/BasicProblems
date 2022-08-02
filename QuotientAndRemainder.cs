using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public static class QuotientAndRemainder
    {
        public static void CheckQuotientAndRemainder()
        {
            int dividend = 25, devisor = 5;

            int quotient = dividend / devisor;
            int remainder = dividend % devisor;

            Console.WriteLine("Quotient is " + quotient);
            Console.WriteLine("Remainder is " + remainder);
        }
    }
}

