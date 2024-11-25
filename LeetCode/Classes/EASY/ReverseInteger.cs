using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class ReverseInteger
    {
        public static void Run()
        {
            int x = 123;
            int result = Reverse(x);
            Console.WriteLine(result);
        }
        public static int Reverse(long x)
        {
            if (x == int.MinValue) return 0;
            long result = 0; 
            while (x != 0)
            {
                long digit = x % 10; 
                x /= 10; 
                if (result > (int.MaxValue / 10) || result < (int.MinValue / 10))
                {
                    return 0;
                }
                result = result * 10 + digit;
            }
            if (result < int.MinValue || result > int.MaxValue)
            {
                return 0;
            }
            return (int)result;
        }

    }
}
