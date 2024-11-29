using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class PowerOfThree
    {
        public static void Run()
        {
            int n = 74088;
            bool result = IsPowerOfThree(n);
            Console.WriteLine(result);
        }
        public  static bool IsPowerOfThree(int n)
        {
            if (n <= 0) return false;
            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }
    }
}
