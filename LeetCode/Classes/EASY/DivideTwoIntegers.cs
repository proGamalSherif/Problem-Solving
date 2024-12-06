using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class DivideTwoIntegers
    {
        public static void Run()
        {
            int dividend = -2147483648, divisor = -1;
            int result = Divide(dividend, divisor);
            Console.WriteLine(result);
        }
        public static int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue; 
            }
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return dividend / divisor;
        }
    }
}
