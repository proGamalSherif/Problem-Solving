using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Classes.EASY
{
    internal class Sqrtx
    {
        public static void Run()
        {
            int x = 16;
            int result = MySqrt(x);
            Console.WriteLine(result);
        }
        public static int MySqrt(int x)
        {
            return (int)Math.Sqrt(x);
        }
    }
}
